using System.Windows.Forms;
using Hypercube.Client.Model;

namespace Hypercube.Control
{
    internal class FixedMetaListViewItem
        : ListViewItem
    {
        internal IMetaModel Model { get; private set; }
        internal FixedMetaListViewItem(IMetaModel model)
        {
            Model = model;
            Text = model.FriendlyName;
        }
    }
}
