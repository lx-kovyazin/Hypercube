using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Hypercube.Client.Model;
using Hypercube.Client.Data.Extractor;

using Hypercube.Client.Method.FullnessMap;
using Microsoft.AnalysisServices.AdomdClient;

using Hypercube.Client.Data;

namespace Hypercube.Client.Method.FullnessMap
{
    public class Map
    {
        public List<Cell> Cells
        {
            get;
            private set;
        }

        private Map(List<Cell> cells)
        {
            Cells = cells;
        }

        static public Map Create(CellSetData data)
        {
            var cellList = new List<Cell>();

            var numCells = data.Dimensions.MembersList.Count;

            for (var i = 0; i < numCells; ++i)
            {
                var cellInfo = new CellInfo();

                for (var n = 0; n < data.Dimensions.Levels.Length; ++n)
                {
                    cellInfo.Info.Add(data.Dimensions.Levels.ElementAt(n),
                                      data.Dimensions.MembersList.ElementAt(i).ElementAt(n));
                }

                var measureList = data.Measures.CellsList.ElementAt(0);

                cellList.Add(CellCalculator.Calculate(cellInfo, measureList));
            }

            return new Map(cellList);
        }
    }
}
