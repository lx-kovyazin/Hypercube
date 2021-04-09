using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AnalysisServices.AdomdClient;
using AdomdDimension = Microsoft.AnalysisServices.AdomdClient.Dimension;
using AdomdHierarchy = Microsoft.AnalysisServices.AdomdClient.Hierarchy;

namespace Hypercube.Client.Model
{
    public class Dimension
        : IMetaModel
    {
        private readonly AdomdDimension dimension;
        private readonly List<Hierarchy> hierarchies;

        public Dimension(AdomdDimension dimension)
        {
            this.dimension = dimension;
            hierarchies = new List<Hierarchy>();
            dimension.Hierarchies
                     .Cast<AdomdHierarchy>()
                     .Where(hierarchy => hierarchy.HierarchyOrigin == HierarchyOrigin.AttributeHierarchy)
                     .ToList()
                     .ForEach(hierarchy => hierarchies.Add(new AttributeHierarchy(hierarchy)));
            dimension.Hierarchies
                     .Cast<AdomdHierarchy>()
                     .Where(hierarchy => hierarchy.HierarchyOrigin == HierarchyOrigin.UserHierarchy)
                     .ToList()
                     .ForEach(hierarchy => hierarchies.Add(new UserHierarchy(hierarchy)));
        }

        public string FriendlyName => dimension.Caption;
        public string UniqueName => dimension.UniqueName;
        public List<Hierarchy> Hierarchies => hierarchies;
    }
}
