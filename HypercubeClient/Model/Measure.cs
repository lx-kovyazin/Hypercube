using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdomdMeasure = Microsoft.AnalysisServices.AdomdClient.Measure;

namespace Hypercube.Client.Model
{
    public class Measure
        : IMetaModel
    {
        private readonly AdomdMeasure measure;

        public Measure(AdomdMeasure measure)
        {
            this.measure = measure;

            //measure.ParentCube.ParentConnection.GetSchemaDataSet()
        }

        public string FriendlyName => measure.Caption;
        public string UniqueName => measure.UniqueName;
    }
}
