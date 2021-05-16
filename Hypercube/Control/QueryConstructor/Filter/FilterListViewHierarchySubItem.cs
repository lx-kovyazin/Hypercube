using Hypercube.Client.Model;

namespace Hypercube.Control.Filter
{
    internal class FilterListViewHierarchySubItem
        : FilterListViewSubItem
    {
        private Hierarchy hierarchy;

        public FilterListViewHierarchySubItem(FilterListViewItem owner)
            : base(owner, null)
        { }

        public Hierarchy Hierarchy
        {
            get => hierarchy;
            set
            {
                hierarchy = value;
                Text = hierarchy.FriendlyName;
            }
        }
    }

}
