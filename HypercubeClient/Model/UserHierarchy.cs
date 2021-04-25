using Microsoft.AnalysisServices.AdomdClient;
using System.Collections.Generic;
using System.Linq;
using AdomdHierarchy = Microsoft.AnalysisServices.AdomdClient.Hierarchy;

namespace Hypercube.Client.Model
{
    public class UserHierarchy
        : Hierarchy
    {
        public UserHierarchy(AdomdHierarchy hierarchy)
            : base(hierarchy)
        { }
    }
}
