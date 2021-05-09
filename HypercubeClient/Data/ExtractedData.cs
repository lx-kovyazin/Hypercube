using System.Collections.Generic;
using System.Linq;
using Hypercube.Client.Model;

namespace Hypercube.Client.Data
{
    public abstract class ExtractedData
    {
        protected ExtractedData(
            (HierarchyLevel[] Levels, List<Member[]> MembersList) dimensions,
            (Measure[] Measures, List<Cell[]> CellsList) measures
            )
        {
            Dimensions = dimensions;
            Measures   = measures;
        }

        public (HierarchyLevel[] Levels, List<Member[]> MembersList) Dimensions
        {
            get;
            set;
        }

        public (Measure[] Measures, List<Cell[]> CellsList) Measures
        {
            get;
            set;
        }

        public (string[] Columns, List<string[]> Rows) JoinTable()
        {
            var columns
                = Dimensions.Levels
                            .Select(l => l.FriendlyName)
                            .Concat(
                                Measures.Measures.Select(m => m.FriendlyName)
                            )
                            .ToArray();

            var dimsRows = new List<string[]>();
            foreach (var ms in Dimensions.MembersList)
                dimsRows.Add(ms.Select(c => c.FriendlyName).ToArray());

            var cellsRows = new List<string[]>();
            foreach (var cs in Measures.CellsList)
                cellsRows.Add(cs.Select(c => c.FriendlyName).ToArray());

            //var rows = dimsRows.Concat(cellsRows).ToList();

            var rows = new List<string[]>();
            for (int i = 0; i < dimsRows.Count; i++)
                rows.Add(dimsRows[i].Concat(cellsRows[i]).ToArray());

            return (columns, rows);
        }

    }
}
