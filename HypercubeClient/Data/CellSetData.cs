using System.Collections.Generic;
using Hypercube.Client.Model;

namespace Hypercube.Client.Data
{
    public sealed class CellSetData
        : ExtractedData
    {
        public CellSetData(
            (HierarchyLevel[] Levels, List<Member[]> MembersList) dimensions,
            (Measure[] Measures, List<Cell[]> CellsList) measures)
            : base(dimensions, measures)
        { }
    }
}
