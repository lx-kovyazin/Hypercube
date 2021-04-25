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
        protected readonly Level level;

        public HierarchyLevel(Level level)
        {
            this.level = level ?? throw new ArgumentNullException(nameof(level));                 
        }

        public string FriendlyName => level.Caption;
        public string UniqueName => level.UniqueName;

        public List<Member> Members => level.GetMembers()
                                            .Cast<AdomdMember>()
                                            .Select(member => new Member(member))
                                            .ToList()
                                            ;
    }
}
