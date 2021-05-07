using System.Collections.Generic;

/*using Hypercube.Client.Model;*/
using Hierarchy = Microsoft.AnalysisServices.AdomdClient.OlapInfoHierarchyCollection;


namespace Hypercube.Client.Method.FullnessMap
{
    class CellInfo
    {
        /*
        public Dictionary<Hierarchy, string> Info
        {
            private set; get;
        }
        */

        /* Для тестов <string, string> */
        public Dictionary<string, string> Info
        {
            private set; get;
        }

        public float Factor
        { 
            private set; get; 
        }

        /*
        public CellInfo(Hierarchy hierarchy)
        {
            Info = new Dictionary<Hierarchy, string>();
            Factor = 0;
        }
        */

        public CellInfo(Hierarchy hierarchy)
        {
            Info = new Dictionary<string, string>();
            Factor = 0;
        }
    }
}
