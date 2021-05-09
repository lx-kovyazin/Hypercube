using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercube.Client.Method.FullnessMap
{
    public class FullnessFactor
    {
        public FullnessFactor(float value)
            => Value = value;

        public float Value
        {
            get;
            private set;
        }

        public static float Calculate(params Model.Cell[] list)
        {
            int count = 0;

            foreach (var value in list)
            {
                if (!string.IsNullOrEmpty(value.UniqueName))
                {
                    ++count;
                }
            }

            return count / list.Length * 100.0f;
        }
    }

    public class Cell
    {
        public CellInfo Info
        {
            get; private set;
        }

        public FullnessFactor Factor
        {
            get; 
            private set;
        }

        public Cell(CellInfo info, FullnessFactor factor)
        {
            Info = info;
            Factor = factor;
        }
    }
}
