using System;
using System.Collections.Generic;
using Hypercube.Client.Extensions;
using Microsoft.AnalysisServices.AdomdClient;
using Hypercube.Client.Model;
using MoreLinq;
using AdomdHierarchy = Microsoft.AnalysisServices.AdomdClient.Hierarchy;
using AdomdMember    = Microsoft.AnalysisServices.AdomdClient.Member;
using AdomdCell      = Microsoft.AnalysisServices.AdomdClient.Cell;
using Cell    = Hypercube.Client.Model.Cell;
using Measure = Hypercube.Client.Model.Measure;
using Member  = Hypercube.Client.Model.Member;
using MdxBuilder.Utils;
using System.Linq;

namespace Hypercube.Client.Data.Extractor
{
    internal static class AdomdDataExtractorExtensions
    {
        public static string ReadCell(this AdomdDataReader reader, int index)
        {
            var cell = Convert.ToString(reader.GetValue(index));
            return cell.IsValuable()
                 ? cell
                 : AdomdDataExtractor.NULL_PLACEHOLDER;
        }
    }

    public sealed class AdomdDataExtractor
        : DataExtractor<AdomdDataExtractor, AdomdDataReader, AdomdData>
    {
        private const string SCHEMA_COLUMN_NAME_TOKEN = "ColumnName";
        private const string MEASURE_AXIS_TOKEN       = "[Measures]";
        private const string MEMBER_NAME_TOKEN        = "[MEMBER_CAPTION]";

        private static string Parse(string value, Func<string, bool> predicate)
            => value.Split('.').Last(predicate).Trim('[', ']');

        private static string ParseMeasure(string value)
            => Parse(value, v => v != MEASURE_AXIS_TOKEN);

        private static string ParseMember(string value)
            => Parse(value, v => v != MEMBER_NAME_TOKEN);

        private static (
                int[] HierarchyLevelColumnIndices,
                int[] MeasureColumnIndices
            )
            ParseIndices(AdomdDataReader reader)
        {
            var schema = reader.GetSchemaTable();
            var indexOfName = schema.Columns.IndexOf(SCHEMA_COLUMN_NAME_TOKEN);

            var hierarchyLevelColumnIndices = new List<int>();
            var measureColumnIndices = new List<int>();
            for (int i = 0; i < schema.Rows.Count; i++)
            {
                var name = schema.Rows[i].ItemArray[indexOfName] as string;
                if (name.StartsWith(MEASURE_AXIS_TOKEN))
                    measureColumnIndices.Add(i);
                else
                    hierarchyLevelColumnIndices.Add(i);
            }

            return (
                hierarchyLevelColumnIndices.ToArray(),
                measureColumnIndices.ToArray()
            );
        }

        private static T[] ReadArrayOf<T>(
                int[] indices,
                Func<int, string> readMethod,
                FluentFunc<string> freandlyCleanUper
            )
            where T : class
        {
            var array = new T[indices.Length];
            for (var index = 0; index < array.Length; index++)
            {
                var value = readMethod?.Invoke(indices[index]);
                array[index] = Activator.CreateInstance(
                    typeof(T), freandlyCleanUper?.Invoke(value), value
                ) as T;
            }
            return array;
        }

        private static (HierarchyLevel[] Levels, Measure[] Measures)
            ReadColumns(
                AdomdDataReader reader,
                (
                    int[] HierarchyLevelColumn,
                    int[] MeasureColumn
                ) indices
            )
            => (
                ReadArrayOf<HierarchyLevel>(
                    indices.HierarchyLevelColumn,
                    reader.GetName,
                    ParseMember
                ),
                ReadArrayOf<Measure>(
                    indices.MeasureColumn,
                    reader.GetName,
                    ParseMeasure
                )
            );

        private static (Member[] Members, Cell[] Cells)
            ReadRow(
                AdomdDataReader reader,
                (
                    int[] HierarchyLevelColumn,
                    int[] MeasureColumn
                ) indices
            )
            => (
                ReadArrayOf<Member>(
                    indices.HierarchyLevelColumn,
                    reader.ReadCell,
                    s => s
                ),
                ReadArrayOf<Cell>(
                    indices.MeasureColumn,
                    reader.ReadCell,
                    s => s
                )
            );

        private static (List<Member[]> MembersList, List<Cell[]> CellsList)
            ReadRows(
                AdomdDataReader reader,
                (
                    int[] HierarchyLevelColumn,
                    int[] MeasureColumn
                ) indices
            )
        {
            var membersList = new List<Member[]>();
            var cellsList = new List<Cell[]>();
            while (reader.Read())
            {
                var (members, cells) = ReadRow(reader, indices);
                membersList.Add(members);
                cellsList.Add(cells);
            }
            return (membersList, cellsList);
        }

        public override AdomdData ReadData(AdomdDataReader reader)
        {
            var indices = ParseIndices(reader);
            var (levels, measures) = ReadColumns(reader, indices);
            var (membersList, cellsList) = ReadRows(reader, indices);
            reader.Dispose();
            return new AdomdData(
                (levels, membersList),
                (measures, cellsList)
            );
        }
    }
}
