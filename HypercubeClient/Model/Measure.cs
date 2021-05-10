using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdomdMeasure = Microsoft.AnalysisServices.AdomdClient.Measure;
using AdomdMember = Microsoft.AnalysisServices.AdomdClient.Member;

namespace Hypercube.Client.Model
{
    public class Measure
        : IMetaModel
    {
        private readonly string friendlyName;
        private readonly string uniqueName;
        private readonly AdomdMeasure measure;
        private readonly AdomdMember  measureMember;

        public Measure(AdomdMeasure measure)
        {
            this.measure = measure
                         ?? throw new ArgumentNullException(nameof(measure));
            friendlyName = this.measure.Caption;
            uniqueName   = this.measure.UniqueName;
        }

        public Measure(AdomdMember measureMember)
        {
            this.measureMember = measureMember
                ?? throw new ArgumentNullException(nameof(measureMember));
            friendlyName       = this.measureMember.Caption;
            uniqueName         = this.measureMember.UniqueName;
        }

        public Measure(string friendlyName, string uniqueName)
        {
            this.friendlyName = friendlyName;
            this.uniqueName   = uniqueName;
        }

        public string FriendlyName => friendlyName;
        public string UniqueName => uniqueName;
    }
}
