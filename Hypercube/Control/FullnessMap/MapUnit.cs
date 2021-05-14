using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hypercube.Client.Method.FullnessMap;

namespace Hypercube.Control.FullnessMap
{
    internal class MapUnit
        : UserControl
    {
        private readonly Cell cell;

        private MapUnit() => InitializeComponent();

        public MapUnit(Cell cell)
            : this()
        {
            this.cell = cell;
            var alpha = cell.Factor.Value * byte.MaxValue / 100F;
            BackColor = Color.FromArgb((int)alpha, BackColor);
        }

        public MapUnit(Cell cell, Color color)
            : this()
        {
            this.cell = cell;
            BackColor = color;
        }

        public Image ToImage()
        {
            var b = new Bitmap(Width, Height);
            DrawToBitmap(b, Bounds);
            return b;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var pen = new Pen(Color.FromArgb(65, 85, 94), 1);
            var rect = Bounds;
            rect.Width--;
            rect.Height--;
            e.Graphics.DrawRectangle(pen, rect);
        }

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
            BackColor = Color.FromArgb(84, 110, 122);
            Margin = new Padding(0);
            Name = "MapUnit";
            Size = new Size(10, 10);
            ResumeLayout(false);

        }
    }
}
