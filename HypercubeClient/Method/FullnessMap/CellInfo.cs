using System.Collections.Generic;

/*using Hypercube.Client.Model;*/
using Microsoft.AnalysisServices.AdomdClient;


namespace Hypercube.Client.Method.FullnessMap
{
    public class Info : Dictionary<Model.HierarchyLevel, Model.Member>
    {}

    public class CellInfo
    {
        public Info Info
        {
            get; set;
        }

        public CellInfo()
        {
            Info = new Info();
        }
    }
}
