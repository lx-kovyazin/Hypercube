using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hypercube.Client.Method.FullnessMap;

namespace Hypercube.Control.FullnessMap
{
    internal class MapUnit
    {
        internal class Prototype
            : Panel, ICloneable
        {
            private const int SIZE = 10;
            public const int MAX_PERCENT = 100;

            private readonly static Color defaultColor = Color.FromArgb(84, 110, 122);
            private readonly int percent;
            private readonly Image image;

            private Prototype()
            {
                SuspendLayout();
                BackColor = defaultColor;
                Margin = new Padding(0);
                Size = new Size(SIZE, SIZE);
                ResumeLayout(false);
            }

            public Prototype(int percent, Color color)
                : this()
            {
                this.percent = percent;
                BackColor = color;
                image = GenerateBitmap();
            }

            public Prototype(int percent)
                : this(
                      percent,
                      Color.FromArgb(
                          percent * byte.MaxValue / MAX_PERCENT,
                          defaultColor
                ))
            { }

            public int Percent => percent;

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

            public object Clone() => MemberwiseClone();

            public override int GetHashCode() => percent + BackColor.ToArgb();

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                var pen = new Pen(Color.FromArgb(65, 85, 94));
                var rect = Bounds;
                rect.Width--;
                rect.Height--;
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private static bool prototypesInitialized;
        private static List<Prototype> unitPrototypes;

        private readonly Prototype prototype;
        private readonly Cell cell;

        private MapUnit(Prototype prototype, Cell cell)
        {
            this.prototype = prototype;
            this.cell = cell;
        }

        public Image Image => prototype.Image;

        public static void InitializePrototypes(
            HashSet<Prototype> levelPrototypes
            )
        {
            const int MAX_PERCENT_COUNT = Prototype.MAX_PERCENT + 1;
            if (levelPrototypes?.Count > MAX_PERCENT_COUNT)
                throw new ArgumentException(
                    $"The count of items must be less than {MAX_PERCENT_COUNT}.",
                    nameof(levelPrototypes)
                );

            var hasItems = levelPrototypes != null
                        && levelPrototypes.Count > 0
                         ;
            unitPrototypes = new List<Prototype>();
            for (int percent = 0; percent < MAX_PERCENT_COUNT; percent++)
            {
                if ( hasItems
                  && levelPrototypes.FirstOrDefault(p => p.Percent == percent)
                        is Prototype prototype
                   )
                {
                    unitPrototypes.Add(prototype);
                    continue;
                }
                unitPrototypes.Add(new Prototype(percent));
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

            var prototype
                = unitPrototypes.Find(up => up.Percent == cell.Factor.Value)
                                .Clone() as Prototype;
            return new MapUnit(prototype, cell);
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
    }
}
