using MaterialSkin.Controls;

namespace Hypercube.Control.Filter
{
    internal class FilterListViewOperatorSubItem
        : FilterListViewSubItem
    {
        private readonly MaterialComboBox operatorComboBox;

        public FilterListViewOperatorSubItem(FilterListViewItem owner)
            : base(owner)
        {
            operatorComboBox = new MaterialComboBox();
            operatorComboBox.Items.AddRange(new string[] { "=", "≠" });
            operatorComboBox.AutoResize = false;
            operatorComboBox.UseTallSize = false;
            Container = operatorComboBox;
        }

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
