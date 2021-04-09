using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AnalysisServices.AdomdClient;
using AdomdHierarchy = Microsoft.AnalysisServices.AdomdClient.Hierarchy;

namespace Hypercube.Client.Model
{
    public abstract class Hierarchy
        : IMetaModel
    {
        protected AdomdHierarchy hierarchy;

        protected Hierarchy(AdomdHierarchy hierarchy)
            => this.hierarchy = hierarchy;

        public string FriendlyName => hierarchy.Caption;
        public string UniqueName => hierarchy.UniqueName;
    }

    public class UserHierarchy
        : Hierarchy
    {
        public UserHierarchy(AdomdHierarchy hierarchy)
            : base(hierarchy)
        { }
    }

    public class AttributeHierarchy
            : Hierarchy
    {
        public AttributeHierarchy(AdomdHierarchy hierarchy)
            : base(hierarchy)
        { }
    }
}
