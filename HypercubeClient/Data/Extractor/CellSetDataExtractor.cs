using System.Collections.Generic;
using System.Linq;
using Hypercube.Client.Model;
using MdxBuilder.Entity;
using Microsoft.AnalysisServices.AdomdClient;
using MoreLinq.Extensions;
using AdomdHierarchy = Microsoft.AnalysisServices.AdomdClient.Hierarchy;
using AdomdMember    = Microsoft.AnalysisServices.AdomdClient.Member;
using AdomdCell      = Microsoft.AnalysisServices.AdomdClient.Cell;
using Cell    = Hypercube.Client.Model.Cell;
using Measure = Hypercube.Client.Model.Measure;
using Member  = Hypercube.Client.Model.Member;

namespace Hypercube.Client.Data.Extractor
{
    public sealed class CellSetDataExtractor
        : DataExtractor<CellSetDataExtractor, CellSet, CellSetData>
    {
        private static (HierarchyLevel[] Levels, List<Member[]> MembersList)
            ReadDimensionData(CellSet set)
        {
            var dimsAxis = set.Axes[(int)AliasedAxis.Alias.Rows];
            var levels
                = dimsAxis
                    .Set
                    .Hierarchies
                    .Cast<AdomdHierarchy>()
                    .SelectMany(
                        h => h.Levels
                              .Cast<Level>()
                              .Where(l => l.LevelType != LevelTypeEnum.All)
                              .Select(l => new HierarchyLevel(l))
                    ).ToArray();
            var levelMembers
                = dimsAxis
                   .Positions
                   .Cast<Position>()
                   .Select(
                       p => p.Members
                             .Cast<AdomdMember>()
                             //.Where(m => m.Type != MemberTypeEnum.All)
                             .Select(m => new Member(m))
                             .ToArray()
                   ).ToList();
            return (levels, levelMembers);
        }

        private static (Measure[] Measures, List<Cell[]> CellsList)
            ReadMeasureData(CellSet set)
        {
            var measures
                = set.Axes[(int)AliasedAxis.Alias.Columns]
                     .Positions
                     .Cast<Position>()
                     .SelectMany(
                         p => p.Members
                               .Cast<AdomdMember>()
                               //.Where(m => m.Type != MemberTypeEnum.All)
                               .Select(m => new Measure(m))
                     ).ToArray();
            var measuresCells
                = set.Cells
                     .Cast<AdomdCell>()
                     .Batch(
                         measures.Length,
                         cells => cells.Select(c => new Cell(c)).ToArray()
                     ).ToList();
            return (measures, measuresCells);
        }

        public override CellSetData ReadData(CellSet dataMedium)
        {
            return new CellSetData(
                ReadDimensionData(dataMedium),
                ReadMeasureData(dataMedium)
            );
        }
    }
}
