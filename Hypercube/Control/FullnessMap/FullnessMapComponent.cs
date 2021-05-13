using System;
using System.Windows.Forms;
using ExtractedData = Hypercube.Client.Data.ExtractedData;
using Map = Hypercube.Client.Method.FullnessMap.Map;

namespace Hypercube.Control.FullnessMap
{
    public partial class FullnessMapComponent
        : UserControl
    {
        private Map map;
        private ExtractedData extractedData;

        public FullnessMapComponent() => InitializeComponent();

        private void Clear()
        {
            viewPanel.Controls.Clear();
            textBoxData.Clear();
        }

        public void LoadData(ExtractedData data)
        {
            Clear();
            extractedData = data;
        }

        private void Unit_MouseClick(object sender, MouseEventArgs e)
        {
            const string separator = "—————";
            textBoxData.AppendText(sender.ToString());
            textBoxData.AppendText(separator + Environment.NewLine);
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            Clear();
            map = Map.Create(extractedData);

            // Add Range impl.
            //var units = new MapUnit[map.Cells.Count];
            //for (int ui = 0; ui < map.Cells.Count; ui++)
            //{
            //    var unit = MapUnit.Create(map.Cells[ui]);
            //    unit.MouseClick += Unit_MouseClick;
            //    units[ui] = unit;
            //}
            //viewPanel.Controls.AddRange(units);

            // Add impl.
            foreach (var cell in map.Cells)
            {
                var unit = MapUnit.Create(cell);
                unit.MouseClick += Unit_MouseClick;
                viewPanel.Controls.Add(unit);
            }

        }
    }
}
