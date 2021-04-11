using System;
using Microsoft.AnalysisServices.AdomdClient;

namespace Hypercube.Client.Model
{
    public class HierarchyLevel
        : IMetaModel
    {
        private readonly Level level;

        public HierarchyLevel(Level level)
            => this.level = level ?? throw new ArgumentNullException(nameof(level));

        public string FriendlyName => level.Caption;
        public string UniqueName => level.UniqueName;
    }
}
