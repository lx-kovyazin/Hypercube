using System.Collections.Generic;
using System.Linq;
using MaterialSkin.Controls;

namespace Hypercube.Control.Filter
{
    internal class FilterListViewOperatorSubItem
        : FilterListViewSubItem
    {
        internal enum Operator
        {
            Equals,
            NotEquals,

        }

        private readonly Dictionary<Operator, string> operatorMap
            = new Dictionary<Operator, string>
            {
                [Operator.Equals]    = "=",
                [Operator.NotEquals] = "≠",
            };

        private readonly MaterialComboBox operatorComboBox;

        public FilterListViewOperatorSubItem(FilterListViewItem owner)
            : base(owner)
        {
            operatorComboBox = new MaterialComboBox();
            operatorComboBox.Items.AddRange(operatorMap.Values.ToArray());
            operatorComboBox.AutoResize = false;
            operatorComboBox.UseTallSize = false;
            Container = operatorComboBox;
        }

        public Operator Current
            => operatorMap.FirstOrDefault(x => x.Value == Text).Key;

        protected override void SetContainerText()
            => operatorComboBox.Hint = Text;

        protected override void SetSubItemText()
        {
            Text = string.IsNullOrEmpty(operatorComboBox.Text)
                 ? operatorComboBox.Hint
                 : operatorComboBox.Text;
        }
    }

}
