using System;
using System.Collections.Generic;
using System.Linq;
using Hypercube.Client.Model;
using MaterialSkin.Controls;

namespace Hypercube.Control.Filter
{
    internal class FilterListViewValueSubItem
        : FilterListViewSubItem
    {
        private readonly Hierarchy hierarchy;
        private readonly MaterialCheckedListBox valueCheckedListBox;
        private readonly List<Member> selectedMembers;

        public FilterListViewValueSubItem(FilterListViewItem owner, Hierarchy hierarchy)
            : base(owner)
        {
            this.hierarchy = hierarchy;
            valueCheckedListBox = new MaterialCheckedListBox();
            selectedMembers = new List<Member>();

            AddRangeItem(
                this.hierarchy
                    .Levels[0]
                    .Members
                    .Select(member => new MaterialCheckbox {
                        Tag  = member,
                        Text = member.FriendlyName
            }));
            RegisterCheckedHandlerForEachItem();
            Container = valueCheckedListBox;
        }

        private void AddRangeItem(IEnumerable<MaterialCheckbox> collection)
            => collection.ToList().ForEach(cb => valueCheckedListBox.Items.Add(cb));

        private void RegisterCheckedHandlerForEachItem()
            => valueCheckedListBox.Items.ToList().ForEach(
                   cb => cb.CheckedChanged += (s, e) => {
                       if (s is MaterialCheckbox scb && scb.Tag is Member m)
                           if (scb.Checked && !selectedMembers.Contains(m))
                               selectedMembers.Add(m);
                           else
                               selectedMembers.Remove(m);
               });

        protected override void SetSubItemText()
            => Text = $"{{ {string.Join(", ", selectedMembers.Select(m => m.FriendlyName))} }}";
    }

}
