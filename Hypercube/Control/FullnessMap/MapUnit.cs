using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Hypercube.Client.Method.FullnessMap;

namespace Hypercube.Control.FullnessMap
{
    public class MapUnit
        : UserControl
    {
        private readonly Cell cell;

        private MapUnit() => InitializeComponent();

        private MapUnit(Cell cell)
            : this()
        {
            this.cell = cell;
            var alpha = cell.Factor.Value * byte.MaxValue / 100F;
            BackColor = Color.FromArgb((int)alpha, BackColor);
        }

        public static MapUnit Create(Cell cell) => new MapUnit(cell);

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("Измерения:");
            foreach (var data in cell.Info.Data)
                builder.AppendLine(
                    $"\t{data.Key.FriendlyName} — {data.Value.FriendlyName}"
                );
            builder.AppendLine($"Заполненность — {cell.Factor.Value}%");
            return builder.ToString();
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            //
            // MapUnit
            //
            Name = "mapUnit";
            Size = new Size(10, 10);
            BackColor = Color.FromArgb(0x54, 0x6E, 0x7A);
            BorderStyle = BorderStyle.FixedSingle;
            ResumeLayout(false);

        }
    }
}
