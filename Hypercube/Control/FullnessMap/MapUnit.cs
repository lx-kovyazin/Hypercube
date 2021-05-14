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

        private static readonly Color defaultColor = Color.FromArgb(84, 110, 122);
        private static bool prototypesInitialized;
        private static List<MapUnit> unitPrototypes;

        private readonly int percent;
        private readonly Image image;
        private Cell cell;

        private MapUnit() => InitializeComponent();

        private MapUnit(int percent, Color color)
            : this()
        {
            this.percent = percent;
            BackColor = color;
            image = GenerateBitmap();
        }

        private MapUnit(int percent)
            : this(
                  percent,
                  Color.FromArgb(
                      percent * byte.MaxValue / MAX_PERCENT,
                      defaultColor
            ))
        { }

        public Image Image => image;

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

        public static void InitializePrototypes(
            Dictionary<int, Color> additionalPrototypes
            )
        {
            const int MAX_PERCENT_COUNT = MAX_PERCENT + 1;
            if (additionalPrototypes?.Count > MAX_PERCENT_COUNT)
                throw new ArgumentException(
                    $"The count of items must be less than {MAX_PERCENT_COUNT}.",
                    nameof(additionalPrototypes)
                );

            var hasItems = additionalPrototypes != null
                        && additionalPrototypes.Count > 0
                         ;
            unitPrototypes = new List<MapUnit>();
            for (int percent = 0; percent < MAX_PERCENT_COUNT; percent++)
            {
                if ( hasItems
                  && additionalPrototypes.TryGetValue(percent, out var color)
                   )
                {
                    unitPrototypes.Add(new MapUnit(percent, color));
                    continue;
                }
                unitPrototypes.Add(new MapUnit(percent));
            }
            prototypesInitialized = true;
        }

        public static MapUnit Create(Cell cell)
        {
            if (!prototypesInitialized)
                throw new Exception(
                      $"The static method \"{nameof(InitializePrototypes)}\""
                    + "must be called before calling this method."
                );

            var unit = unitPrototypes.Find(u => u.percent == cell.Factor.Value)
                                     .Clone() as MapUnit;
            unit.cell = cell;
            return unit;
        }

        public object Clone() => MemberwiseClone();

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
            BackColor = defaultColor;
            Margin = new Padding(0);
            Name = "MapUnit";
            Size = new Size(10, 10);
            ResumeLayout(false);

        }
    }
}
