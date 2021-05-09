using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdomdCell = Microsoft.AnalysisServices.AdomdClient.Cell;


namespace Hypercube.Client.Model
{
    public class Cell
        : IMetaModel
    {
        private readonly AdomdCell cell;

        public Cell(AdomdCell cell)
            => this.cell = cell;

        public string FriendlyName => cell.FormattedValue;

        public string UniqueName => cell.Value.ToString();
    }
}
