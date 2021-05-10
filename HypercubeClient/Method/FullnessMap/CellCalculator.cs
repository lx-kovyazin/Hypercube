using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercube.Client.Method.FullnessMap
{
    public static class CellCalculator
    {
        public static Cell Calculate(CellInfo info, params Model.Cell[] measurelist)
        {
            var factor = FullnessFactor.Calculate(measurelist);

            return new Cell(info, factor);
        }
    }
}
