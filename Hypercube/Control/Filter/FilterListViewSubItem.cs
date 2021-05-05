using System;
using System.Windows.Forms;
using WinFormsControl = System.Windows.Forms.Control;

namespace Hypercube.Control.Filter
{
    internal class FilterListViewSubItem
        : ListViewItem.ListViewSubItem, IFilterListViewSubItem
    {
        const string DEFAULT_TEXT = "<Выбрать>";

        private readonly FilterListViewItem owner;
        private WinFormsControl container;

        protected FilterListViewSubItem(FilterListViewItem owner)
            : base(owner, DEFAULT_TEXT)
                => this.owner = owner;

        public FilterListViewSubItem(FilterListViewItem owner, WinFormsControl container)
            : this(owner)
                => Container = container;

        public WinFormsControl Container
        {
            get => container;
            protected set
            {
                if (value != null)
                {
                    container = value;
                    container.Visible = false;
                }
            }
        }

        public int Index => owner.SubItems.IndexOf(this);

        protected virtual void InitializeContainer()
        {
            var subItemContainer = Container;
            var tempHight = subItemContainer.Bounds.Height;

            subItemContainer.Bounds = Bounds;
            subItemContainer.Width = owner.ListView.Columns[Index].Width;
            //subItemContainer.Height = subItem.Bounds.Height;
            subItemContainer.Height = tempHight;
            subItemContainer.Font = Font;
        }

        protected virtual void SetContainerText() => Container.Text = Text;

        protected virtual void SetSubItemText() => Text = Container.Text;

        // TODO: Implement later maybe.
        //private void ContainerLink_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    switch ((Keys)e.KeyChar)
        //    {
        //        case Keys.Escape:
        //            //RemoveContainerLink();
        //            break;

        //        case Keys.Enter:
        //            //SwitchValueContainerLink();
        //            //RemoveContainerLink();
        //            break;

        //        default:
        //            break;
        //    }
        //}

        private void ContainerLink_Leave(object sender, EventArgs e)
        {
            SetSubItemText();
            HideContainer();
        }

        public void ShowContainer()
        {
            if (Container is null)
                return;
            InitializeContainer();
            SetContainerText();

            owner.ListView.Controls.Add(Container);

            Container.Leave += ContainerLink_Leave;
            
            // TODO: Implement later maybe.
            //Container.KeyPress += ContainerLink_KeyPress;

            Container.Visible = true;
            Container.BringToFront();
            Container.Focus();
        }

        public void HideContainer()
        {
            if (Container is null)
                return;

            Container.Visible = false;

            // TODO: Implement later maybe.
            //Container.KeyPress -= ContainerLink_KeyPress;
            Container.Leave -= ContainerLink_Leave;

            owner.ListView.Controls.Remove(Container);
        }
    }

}
