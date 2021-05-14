using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hypercube.Client.Method.FullnessMap;

namespace Hypercube.Control.FullnessMap
{
    internal class MapUnit
        : UserControl, ICloneable
    {
        private const int MAX_PERCENT = 100;

        private readonly int percent;
        private readonly Image image;
        private Cell cell;

        private MapUnit() => InitializeComponent();

        private MapUnit(int percent)
            : this()
        {
            this.percent = percent;
            var alpha = percent * byte.MaxValue / MAX_PERCENT;
            BackColor = Color.FromArgb(alpha, BackColor);
            image = GenerateBitmap();
        }

        private MapUnit(Cell cell, Color color)
            : this()
        {
            this.cell = cell;
            BackColor = color;
        }

        private Bitmap GenerateBitmap()
        {
            var b = new Bitmap(Width, Height);
            try
            {
                DrawToBitmap(b, Bounds);
            }
            catch (Win32Exception ex)
            {
                Debug.Print(ex.ToString());
            }
            return b;
        }

        public Image ToImage() => image;

        private static bool prototypesInitialized;
        private static List<MapUnit> unitPrototypes;

        private static void InitializePrototypes()
        {
            unitPrototypes = new List<MapUnit>(MAX_PERCENT + 1);
            for (int percent = 0; percent < unitPrototypes.Capacity; percent++)
                unitPrototypes.Add(new MapUnit(percent));
            prototypesInitialized = true;
        }

        public static MapUnit Create(Cell cell)
        {
            if (!prototypesInitialized)
                InitializePrototypes();

            var unit = unitPrototypes.Find(u => u.percent == cell.Factor.Value)
                                     .Clone() as MapUnit;
            unit.cell = cell;
            return unit;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var pen = new Pen(Color.FromArgb(65, 85, 94));
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

        public object Clone() => MemberwiseClone();
    }
}
