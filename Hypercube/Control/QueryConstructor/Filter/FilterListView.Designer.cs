using System.Windows.Forms;

namespace Hypercube.Control.Filter
{
    partial class FilterListView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dimensionHeader = new ColumnHeader();
            this.operatorHeader  = new ColumnHeader();
            this.valueHeader     = new ColumnHeader();
            this.SuspendLayout();
            // 
            // dimensionHeader
            // 
            this.dimensionHeader.Text = "Измерение";
            this.dimensionHeader.Width = 148;
            // 
            // operatorHeader
            // 
            this.operatorHeader.Text = "Оператор";
            this.operatorHeader.Width = 156;
            // 
            // valueHeader
            // 
            this.valueHeader.Text = "Значение";
            this.valueHeader.Width = 149;
            // 
            // this
            //
            this.Columns.AddRange(new ColumnHeader[] {
                this.dimensionHeader,
                this.operatorHeader,
                this.valueHeader
            });
            this.AutoSizeTable = false;
            this.Depth = 0;
            this.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MouseState = MaterialSkin.MouseState.OUT;
            this.FullRowSelect = true;
            this.View = View.Details;
            this.ResumeLayout(false);

        }

        #endregion

        private ColumnHeader dimensionHeader;
        private ColumnHeader operatorHeader;
        private ColumnHeader valueHeader;

        //private const int WM_HSCROLL = 0x114;
        //private const int WM_VSCROLL = 0x115;

        //protected override void WndProc(ref Message msg)
        //{
        //    // Look for the WM_VSCROLL or the WM_HSCROLL messages.
        //    if ((msg.Msg == WM_VSCROLL) || (msg.Msg == WM_HSCROLL))
        //    {
        //        // Move focus to the ListView to cause ComboBox to lose focus.
        //        this.Focus();
        //    }

        //    // Pass message to default handler.
        //    base.WndProc(ref msg);
        //}
    }
}
