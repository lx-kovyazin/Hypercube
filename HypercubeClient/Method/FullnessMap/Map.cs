using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Hypercube.Client.Method.FullnessMap;
using Microsoft.AnalysisServices.AdomdClient;

namespace Hypercube.Client.Method.FullnessMap
{
    public class Map
    {
        public Map()
        {
        
        }

        public void LoadData(CellSet set)
        {
            var numDimentions = set.OlapInfo.AxesInfo.Axes[1].Hierarchies.Count;
            var numMeasures   = set.Axes[0].Set.Tuples.Count;

            var numRows = set.Axes[1].Set.Tuples.Count;

            var keyName = "none";
            var data = "none";

            var temp = set.OlapInfo.AxesInfo.Axes[1].Hierarchies;

            for (int row = 0; row < numRows; row += numMeasures)
            {
                CellInfo info = new CellInfo();

                for (int dim = 0; dim < numDimentions; ++dim)
                {
                    keyName = temp[dim].Name.Split('.')[1].Trim('[', ']');
                    data = set.Axes[1].Positions[row].Members[dim].Caption;

                    info.Info.Dimentions.Add(keyName, data);
                }

                for (int n = 0; n < numMeasures; ++n)
                {
                    keyName = set.Axes[0].Positions[n].Members[0].Caption;
                    data = set.Cells[row + n].FormattedValue;

                    info.Info.Measures.Add(keyName, data);
                }

                Cell cell = CellCalculator.Calculate(info);
            }

            //string test1 = set.OlapInfo.AxesInfo.Axes[1].Hierarchies[0].Name;
            //string test2 = set.OlapInfo.AxesInfo.Axes[1].Hierarchies[1].Name;
            //string test3 = set.OlapInfo.AxesInfo.Axes[1].Hierarchies[2].Name;
        }
    }
}
