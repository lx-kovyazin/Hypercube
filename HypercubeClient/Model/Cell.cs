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
        private readonly string friendlyName;
        private readonly string uniqueName;
        private readonly AdomdCell cell;

        public Cell(AdomdCell cell)
        {
            this.cell = cell
                     ?? throw new ArgumentNullException(nameof(cell));
            if (this.cell.Value is null)
                friendlyName = uniqueName = "(null)";
            else
            {
                friendlyName = this.cell.FormattedValue;
                uniqueName = this.cell.Value.ToString();
            }
        }

        public Cell(string friendlyName, string uniqueName)
        {
            this.friendlyName = friendlyName;
            this.uniqueName   = uniqueName;
        }

        public string FriendlyName => friendlyName;

        public string UniqueName => uniqueName;
    }
}
