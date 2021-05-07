using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercube.Client.Method.FullnessMap
{
    static class FullnessFactorCalculator
    {
        static float Calculate(CellInfo info)
        {
            int count = 0;

            foreach (var value in info.Info)
            {
                if (!String.IsNullOrEmpty(value.Value))
                {
                    ++count;
                }
            }

            return count / info.Info.Count * 100;
        }
    }
}
