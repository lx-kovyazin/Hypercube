using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Hypercube.Control.FullnessMap
{
    internal static class PercentAddedValidator
    {
        public static bool IsAlreadyAdded(this HashSet<MapUnit.Prototype> set, int percent)
        {
            bool result = false;

            foreach (var item in set)
            {
                if (item.Percent == percent)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }
    }

    public partial class MapUnitLevelSet
        : MaterialListView
    {
        private readonly HashSet<MapUnit.Prototype> set;

        public MapUnitLevelSet()
        {
            InitializeComponent();
            set = new HashSet<MapUnit.Prototype>();
        }

        internal HashSet<MapUnit.Prototype> Set => set;

        public bool Add(int percent, Color color)
        {
            var result = set.IsAlreadyAdded(percent);

            if (!result)
            {
                result = set.Add(new MapUnit.Prototype(percent, color));
                if (result)
                    Items.Add($"{percent}%");
            }

            return result;
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                SelectedItems.Cast<ListViewItem>()
                             .ToList()
                             .ForEach(item => {
                                 set.Remove(set.ElementAt(Items.IndexOf(item)));
                                 item.Remove();
                             });
        }

        protected override void OnDrawItem(DrawListViewItemEventArgs e)
        {
            base.OnDrawItem(e);
            if (set.Count > 0)
            {
                var protoItem = set.ElementAt(e.ItemIndex);
                var bounds    = e.Item.Bounds;
                var halfSize  = protoItem.Size.Height / 2;
                e.Graphics.DrawImage(protoItem.Image, new Rectangle(
                    new Point(
                        bounds.Location.X + halfSize,
                        bounds.Location.Y + halfSize
                    ),
                    protoItem.Size
                ));
            }
        }
    }
}
