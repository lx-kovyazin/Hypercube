using System;
using System.Windows.Forms;
using AdamsLair.WinForms.ItemModels;
using ExtractedData = Hypercube.Client.Data.ExtractedData;
using Map = Hypercube.Client.Method.FullnessMap.Map;

namespace Hypercube.Control.FullnessMap
{
    public partial class FullnessMapComponent
        : UserControl
    {
        private Map map;
        private ExtractedData extractedData;

        public FullnessMapComponent()
        {
            InitializeComponent();
            viewPanel.ItemAppearance += (s, e) => {
                e.DisplayedText = null;
                e.DisplayedImage = (e.Item as MapUnit).ToImage();
            };
            viewPanel.ItemClicked += (s, e) => {
                const string separator = "—————";
                textBoxData.AppendText(e.Item.ToString());
                textBoxData.AppendText(separator + Environment.NewLine);
            };
        }

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

        private void BuildButton_Click(object sender, EventArgs e)
        {
            Clear();
            if (extractedData is null)
                return;

            map = Map.Create(extractedData);
            var mapModel = new ListModel<MapUnit>();
            foreach (var cell in map.Cells)
            {
                var unit = MapUnit.Create(cell);
                mapModel.Add(unit);
            }
            viewPanel.Model = mapModel;
        }
    }
}
