using System.Windows.Forms;
using Hypercube.Client.Model;

namespace Hypercube.Control.Filter
{
    internal class FilterListViewItem
        : ListViewItem
    {
        public FilterListViewItem(Hierarchy hierarchy)
        {
            SubItems.Add(new FilterListViewHierarchySubItem(this) {
                Hierarchy = hierarchy
            });
            SubItems.Add(new FilterListViewOperatorSubItem(this));
            SubItems.Add(new FilterListViewValueSubItem(this, hierarchy));
            SubItems.RemoveAt(0);
        }
    }
}
