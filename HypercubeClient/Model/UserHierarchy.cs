using Microsoft.AnalysisServices.AdomdClient;
using System.Collections.Generic;
using System.Linq;
using AdomdHierarchy = Microsoft.AnalysisServices.AdomdClient.Hierarchy;

namespace Hypercube.Client.Model
{
    public class UserHierarchy
        : Hierarchy
    {
        private readonly List<HierarchyLevel> levels;
        public UserHierarchy(AdomdHierarchy hierarchy)
            : base(hierarchy)
        {
            levels = new List<HierarchyLevel>();
            hierarchy.Levels
                     .Cast<Level>()
                     .Where(level => level.LevelType != LevelTypeEnum.All)
                     .ToList()
                     .ForEach(level => levels.Add(new HierarchyLevel(level)));
        }

        public List<HierarchyLevel> Levels => levels;
    }
}
