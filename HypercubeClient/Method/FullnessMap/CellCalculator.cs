using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercube.Client.Method.FullnessMap
{
    public static class CellCalculator
    {
        public static Cell Calculate(CellInfo info)
        {
            int count = 0;

            foreach (var value in info.Info.Measures)
            {
                if (!string.IsNullOrEmpty(value.Value))
                {
                    ++count;
                }
            }

            float factor = count / info.Info.Measures.Count * 100.0f;

            return new Cell(info, new FullnessFactor(factor));
        }
    }
}
