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
        private readonly AdomdMeasure measure;
        private readonly AdomdMember  measureMember;

        public Measure(AdomdMeasure measure)
            => this.measure = measure;
        
        public Measure(AdomdMember measureMember)
            => this.measureMember = measureMember;

        public string FriendlyName => measure is null
                                    ? measureMember.Caption
                                    : measure.Caption;
        public string UniqueName => measure is null
                                    ? measureMember.UniqueName
                                    : measure.UniqueName;
    }
}
