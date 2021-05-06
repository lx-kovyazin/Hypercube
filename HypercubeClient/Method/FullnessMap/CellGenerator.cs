using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace Hypercube.Client.Method.FullnessMap
{
    class CellGenerator<T> where T : Control
    {
        private static T prevCell;
        private static Size controlSize = new Size(10, 10);

        internal static T Generate(CellInfo info)
        {

            return (T)Activator.CreateInstance(typeof(T));
        }
    }
}
