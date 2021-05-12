using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Map = Hypercube.Client.Method.FullnessMap.Map;
using CellSetData = Hypercube.Client.Data.CellSetData;
using ExtractedData = Hypercube.Client.Data.ExtractedData;

namespace Hypercube.Control.FullnessMap
{
    public partial class FullnessMapComponent : UserControl
    {
        public FullnessMapComponent()
        {
            InitializeComponent();
        }

        public ExtractedData Data
        {
            get;
            private set;
        }

        private Map Map
        {
            get;
            set;
        }

        public void LoadData(ExtractedData data)
        {
            viewPanel.Controls.Clear();
            textBoxData.Clear();

            Data = data;
            Map = Map.Create(Data);
        }

        private void Unit_MouseClick(object sender, MouseEventArgs e)
        {
            MapUnit unit = (MapUnit)sender;

            string hierarchy = "Иерархия :\r\n";
            string factor = $"Заполненность = { unit.Cell.Factor.Value }%\r\n";

            foreach (var data in unit.Cell.Info.Data)
            {
                hierarchy += $"{ data.Key.FriendlyName } : { data.Value.FriendlyName }\r\n";
            }

            textBoxData.AppendText(hierarchy + factor);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            viewPanel.Controls.Clear();
            textBoxData.Clear();

            MapUnit prevUnit = null;

            foreach (var cell in Map.Cells)
            {
                MapUnit unit = MapUnit.Create(cell);
                unit.MouseClick += Unit_MouseClick;

                if (prevUnit != null)
                {
                    var newPoint = new Point(prevUnit.Location.X, prevUnit.Location.X);
                    newPoint.Offset(prevUnit.Size.Width, 0);
                    unit.Location = newPoint;
                }

                prevUnit = unit;

                viewPanel.Controls.Add(unit);

                prevUnit = unit;
            }
        }
    }
}
