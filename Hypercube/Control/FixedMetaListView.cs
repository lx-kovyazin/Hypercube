using Hypercube.Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hypercube.Control
{
    public partial class FixedMetaListView : UserControl
    {
        private readonly Assembly hypercubeClientAssembly;
        public FixedMetaListView()
        {
            InitializeComponent();
            hypercubeClientAssembly = Assembly.Load("HypercubeClient");
            ResizeHeader();
        }

        [Description("The name of a list view.")]
        public string Header {
            get { return fixedListHeader.Text; }
            set { fixedListHeader.Text = value; }
        }

        [Description("The type name of list view items.")]
        public string TypeName { get; set; }

        private Type MetaType => hypercubeClientAssembly.GetType(TypeName);

        private void ResizeHeader()
        {
            const int MAGIC_SIZE = -2;
            fixedListHeader.Width = MAGIC_SIZE;
        }

        private void FixedListView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void FixedListView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.AllowedEffect == DragDropEffects.Move)
            {
                e.Effect = e.AllowedEffect;
                return;
            }

            if (e.GetDragMetaData(MetaType) is IMetaModel model
                && !(fixedListView.Items.Count > 0
                    && fixedListView.Items.Cast<FixedMetaListViewItem>().Any(item => item.Model.Equals(model))))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void FixedListView_DragDrop(object sender, DragEventArgs e)
        {
            if (e.AllowedEffect == DragDropEffects.Link)
                fixedListView.Items.Add(new FixedMetaListViewItem(e.GetDragMetaData(MetaType) as IMetaModel));

            if (e.AllowedEffect == DragDropEffects.Move)
            {
                var targetPoint = fixedListView.PointToClient(new Point(e.X, e.Y));
                var targetItem = fixedListView.GetItemAt(targetPoint.X, targetPoint.Y);
                if (targetItem == null)
                    return;

                var draggedItem = e.GetDragData<FixedMetaListViewItem>();
                if (draggedItem.Equals(targetItem))
                    return;

                var targetItemIndex = targetItem.Index;
                var draggedItemIndex = draggedItem.Index;
                var offset = draggedItemIndex < targetItemIndex ? 1 : 0;
                draggedItem.Remove();
                fixedListView.Items.Insert(targetItem.Index + offset, draggedItem);
            }
        }

        private void FixedListView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                fixedListView.SelectedItems.Cast<ListViewItem>().ToList().ForEach(item => item.Remove());
        }

        private void FixedListView_Resize(object sender, EventArgs e)
        {
            ResizeHeader();
        }
    }
}
