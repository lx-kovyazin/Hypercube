using System;
using System.Drawing;
using System.Windows.Forms;
using Hypercube.Client.Method.FullnessMap;

namespace Hypercube.Client.Methods
{
    public class MapUnit :UserControl
    {
        public Cell Cell 
        { 
            get; 
            private set; 
        }

        public static MapUnit Create(Cell cell)
        {
            float alpha = cell.Factor.Value * byte.MaxValue / 100.0f;
            Color unitColor = Color.FromArgb(84, 110, 122);

            MapUnit unit = new MapUnit()
            {
                Cell = cell,

                Size = new Size(10, 10),
                BackColor = Color.FromArgb((int)alpha, unitColor)
            };

            return unit;
        }
    }
}
