using Hypercube.Client.Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
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
        public string Header
        {
            get { return fixedListHeader.Text; }
            set { fixedListHeader.Text = value; }
        }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Description("The type name of list view items.")]
        public List<string> TypeNameList { get; private set; } = new List<string>();

        private IEnumerable<Type> GetMetaType()
        {
            foreach (var type in TypeNameList)
                yield return hypercubeClientAssembly.GetType(type);
        }

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

            foreach (var metaType in GetMetaType())
            {
                if (e.GetDragMetaData(metaType) is IMetaModel model
                    && !(fixedListView.Items.Count > 0
                        && fixedListView.Items.Cast<FixedMetaListViewItem>().Any(item => item.Model.Equals(model))))
                {
                    e.Effect = DragDropEffects.Link;
                    break;
                }
                else
                    e.Effect = DragDropEffects.None;
            }
        }


        private void HandleLinkDragDrop(object sender, DragEventArgs e)
        {
            foreach (var metaType in GetMetaType())
                switch (e.GetDragMetaData(metaType))
                {
                    case IMetaModel metaModel 
                        when metaModel is Measure
                          || metaModel is AttributeHierarchy
                          || metaModel is HierarchyLevel:
                        fixedListView.Items.Add(new FixedMetaListViewItem(metaModel));
                        break;

                    case UserHierarchy userHierarchy
                        when userHierarchy.Levels.Count > 0:
                        userHierarchy.Levels.ForEach(
                            level => fixedListView.Items.Add(new FixedMetaListViewItem(level))
                        );
                        break;

                    default:
                        break;
                }
        }

        private void HandleMoveDragDrop(object sender, DragEventArgs e)
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

        private void FixedListView_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.AllowedEffect)
            {
                case DragDropEffects.Move:
                    HandleMoveDragDrop(sender, e);
                    break;
                case DragDropEffects.Link:
                    HandleLinkDragDrop(sender, e);
                    break;
                default:
                    break;
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
