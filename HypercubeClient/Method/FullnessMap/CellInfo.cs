using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Hierarchy = Microsoft.AnalysisServices.AdomdClient.OlapInfoHierarchyCollection;

namespace Hypercube.Client.Method.FullnessMap
{
    class CellInfo
    {
        public Dictionary<Hierarchy, string> Info
        {
            private set; get;
        }

        public decimal Factor 
        { 
            private set; get; 
        }

        public CellInfo(Hierarchy hierarchy)
        {
            Info = new Dictionary<Hierarchy, string>();
            Factor = 0;
        }
    }
}
