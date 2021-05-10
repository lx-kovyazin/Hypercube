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
        private readonly string friendlyName;
        private readonly string uniqueName;
        protected readonly AdomdMember member;

        public Member(AdomdMember member)
        {
            this.member = member
                       ?? throw new ArgumentNullException(nameof(member));
            if (this.member.Caption.Length is 0)
            {
                friendlyName = uniqueName = "(null)";
            }
            else
            {
                friendlyName = this.member.Caption;
                uniqueName   = this.member.UniqueName;
            }
        }

        public Member(string friendlyName, string uniqueName)
        {
            this.friendlyName = friendlyName;
            this.uniqueName   = uniqueName;
        }

        public string FriendlyName => friendlyName;
        public string UniqueName => uniqueName;
    }
}
