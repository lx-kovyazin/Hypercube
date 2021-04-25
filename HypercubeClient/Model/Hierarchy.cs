using Microsoft.AnalysisServices.AdomdClient;
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
        protected readonly List<HierarchyLevel> levelList;
        protected Hierarchy(AdomdHierarchy hierarchy)
        {
            this.hierarchy = hierarchy ?? throw new ArgumentNullException(nameof(hierarchy));

            levelList = new List<HierarchyLevel>();
            hierarchy.Levels
                     .Cast<Level>()
                     .Where(level => level.LevelType != LevelTypeEnum.All)
                     .ToList()
                     .ForEach(level => levelList.Add(new HierarchyLevel(level)));
        }

        public string FriendlyName => hierarchy.Caption;
        public string UniqueName => hierarchy.UniqueName;
        public List<HierarchyLevel> Levels => levelList;
    }
}
