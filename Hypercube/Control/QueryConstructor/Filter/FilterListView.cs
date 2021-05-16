using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using WinFormsControl = System.Windows.Forms.Control;

using MaterialSkin.Controls;
using Hypercube.Client.Model;

namespace Hypercube.Control.Filter
{
    public partial class FilterListView
        : MaterialListView
    {
        public FilterListView()
        {
            InitializeComponent();
            ResizeHeaders();
            AllowDrop = true;
            //Resize += (s, e) => ResizeHeaders();
        }

        private void AddItem(Hierarchy hierarchy)
            => Items.Add(new FilterListViewItem(hierarchy));

        private void ResizeHeaders()
        {
            const int MAGIC_SIZE = -2;
            Columns.Cast<ColumnHeader>()
                   .ToList()
                   .ForEach(header => header.Width = MAGIC_SIZE);
        }

        protected override void OnDragEnter(DragEventArgs e)
        {
            base.OnDragEnter(e);

            Debug.Print($"[{nameof(OnDragEnter)}] : ENTER");
            if (e.AllowedEffect == DragDropEffects.Link)
            {
                Debug.Print($"[{nameof(OnDragEnter)}] : {DragDropEffects.Link}");

                switch (e.GetDragMetaData<Hierarchy>())
                {
                    case Hierarchy hierarchy
                        when hierarchy is AttributeHierarchy:
                        Debug.Print($"[{nameof(OnDragEnter)}] Allow");
                        e.Effect = e.AllowedEffect;
                        break;

                    default:
                        break;
                }
            }
            Debug.Print($"[{nameof(OnDragEnter)}] OUT");
        }

        protected override void OnDragDrop(DragEventArgs e)
        {
            base.OnDragDrop(e);

            Debug.Print($"[{nameof(OnDragDrop)}] : ENTER");
            if (e.AllowedEffect == DragDropEffects.Link)
            {
                Debug.Print($"[{nameof(OnDragDrop)}] : {DragDropEffects.Link}");
                switch (e.GetDragMetaData<Hierarchy>())
                {
                    case Hierarchy hierarchy
                        when hierarchy is AttributeHierarchy:
                        Debug.Print($"[{nameof(OnDragDrop)}] Drop");
                        AddItem(hierarchy);
                        break;

                    default:
                        break;
                }
            }
            Debug.Print($"[{nameof(OnDragDrop)}] : OUT");
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                SelectedItems.Cast<ListViewItem>().ToList().ForEach(item => item.Remove());
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Debug.Print($"{nameof(OnMouseUp)} ENTER");
            if (!(GetItemAt(e.X, e.Y) is FilterListViewItem item))
                return;

            if (!(item.GetSubItemAt(e.X, e.Y) is IFilterListViewSubItem subItem))
                return;

            subItem.ShowContainer();

            Debug.Print($"{nameof(OnMouseUp)} OUT");
        }
    }
}
