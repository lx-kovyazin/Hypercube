using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdomdHierarchy = Microsoft.AnalysisServices.AdomdClient.Hierarchy;

namespace Hypercube.Client.Model
{
    public abstract class Hierarchy
        : IMetaModel
    {
        protected readonly AdomdHierarchy hierarchy;

        protected Hierarchy(AdomdHierarchy hierarchy)
            => this.hierarchy = hierarchy ?? throw new ArgumentNullException(nameof(hierarchy));

        public string FriendlyName => hierarchy.Caption;
        public string UniqueName => hierarchy.UniqueName;
    }
}
