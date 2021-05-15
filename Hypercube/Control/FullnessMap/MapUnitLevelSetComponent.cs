using System.Windows.Forms;

namespace Hypercube.Control.FullnessMap
{
    public partial class MapUnitLevelSetComponent
        : UserControl
    {
        public MapUnitLevelSetComponent()
        {
            InitializeComponent();
            addButton.Click += (s, e)
                => mapUnitLevelSet.Add(
                    (int)percentUpDown.Value,
                    colorPanel.Value
                );
        }
    }
}
