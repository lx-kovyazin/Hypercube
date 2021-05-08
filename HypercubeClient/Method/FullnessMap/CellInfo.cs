using System.Collections.Generic;

/*using Hypercube.Client.Model;*/
using Microsoft.AnalysisServices.AdomdClient;


namespace Hypercube.Client.Method.FullnessMap
{
    public class Info
    {
        public Dictionary<string, string> Dimentions
        {
            get; set;
        }

        public Dictionary<string, string> Measures
        {
            get; set;
        }

        public Info() 
        {
            Dimentions = new Dictionary<string, string>();
            Measures = new Dictionary<string, string>();
        }
    }

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
