using System.Collections.Generic;

/*using Hypercube.Client.Model;*/
using Microsoft.AnalysisServices.AdomdClient;


namespace Hypercube.Client.Method.FullnessMap
{
    public class Info : Dictionary<Model.HierarchyLevel, Model.Member>
    {}

    public class CellInfo
    {
        public Info Data
        {
            get; set;
        }

        public CellInfo()
        {
            Data = new Info();
        }
    }
}
