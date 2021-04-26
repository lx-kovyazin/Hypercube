using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AnalysisServices.AdomdClient;
using AdomdMember = Microsoft.AnalysisServices.AdomdClient.Member;

namespace Hypercube.Client.Model
{
    public class Member
        : IMetaModel
    {
        protected readonly AdomdMember member;

        public Member(AdomdMember member)
            => this.member = member ?? throw new ArgumentNullException(nameof(member));

        public string FriendlyName => member.Caption;
        public string UniqueName => member.UniqueName;
    }
}
