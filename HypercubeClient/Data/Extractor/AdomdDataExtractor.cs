using System;
using System.Collections.Generic;
using Hypercube.Client.Extensions;
using Microsoft.AnalysisServices.AdomdClient;

namespace Hypercube.Client.Data.Extractor
{
    public sealed class AdomdDataExtractor
        : DataExtractor<AdomdDataExtractor, AdomdDataReader, AdomdData>
    {
        private static string[] ReadColumns(AdomdDataReader reader)
        {
            reader.FieldCount.Trace(nameof(reader.FieldCount));
            var columns = new string[reader.FieldCount];
            for (var index = 0; index < columns.Length; index++)
                columns[index] = reader.GetName(index);
            return columns;
        }

        private static object ReadCell(AdomdDataReader reader, int index)
        {
            var cell = Convert.ToString(reader.GetValue(index));
            return cell.IsValuable() ? cell : NULL_PLACEHOLDER;
        }

        private static object[] ReadRow(AdomdDataReader reader, int cellCount)
        {
            var row = new object[cellCount];
            for (int cellIndex = 0; cellIndex < cellCount; cellIndex++)
                row[cellIndex] = ReadCell(reader, cellIndex);
            return row;
        }

        private static List<object[]> ReadRows(AdomdDataReader reader, int cellCount)
        {
            cellCount.Trace(nameof(cellCount));
            var rows = new List<object[]>();
            while (reader.Read())
                rows.Add(ReadRow(reader, cellCount));
            return rows;
        }

        public override AdomdData ReadData(AdomdDataReader reader)
        {
            var columns = ReadColumns(reader);
            var rows = ReadRows(reader, columns.Length);

            //return new AdomdData(, null);
            return null;
        }
    }
}
