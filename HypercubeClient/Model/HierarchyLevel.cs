using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AnalysisServices.AdomdClient;
using AdomdMember = Microsoft.AnalysisServices.AdomdClient.Member;

namespace Hypercube.Client.Model
{
    public class HierarchyLevel
        : IMetaModel
    {
        private readonly string friendlyName;
        private readonly string uniqueName;
        private readonly Level level;

        public HierarchyLevel(Level level)
        {
            this.level   = level
                         ?? throw new ArgumentNullException(nameof(level));
            friendlyName = this.level.Caption;
            uniqueName   = this.level.UniqueName;
        }

        public HierarchyLevel(string friendlyName, string uniqueName)
        {
            this.friendlyName = friendlyName;
            this.uniqueName   = uniqueName;
        }

        public string FriendlyName => friendlyName;
        public string UniqueName => uniqueName;

        public List<Member> Members => level.GetMembers()
                                            .Cast<AdomdMember>()
                                            .Select(member => new Member(member))
                                            .ToList()
                                            ;
    }
}
