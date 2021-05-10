using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercube.Client.Method.FullnessMap
{
    public class Cell
    {
        public CellInfo Info
        {
            get; 
            private set;
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
