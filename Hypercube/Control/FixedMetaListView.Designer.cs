
namespace Hypercube.Control
{
    partial class FixedMetaListView
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
            this.fixedListView = new MaterialSkin.Controls.MaterialListView();
            this.fixedListHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // fixedListView
            // 
            this.fixedListView.AllowDrop = true;
            this.fixedListView.AutoSizeTable = false;
            this.fixedListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fixedListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fixedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fixedListHeader});
            this.fixedListView.Depth = 0;
            this.fixedListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fixedListView.FullRowSelect = true;
            this.fixedListView.GridLines = true;
            this.fixedListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.fixedListView.HideSelection = false;
            this.fixedListView.Location = new System.Drawing.Point(0, 0);
            this.fixedListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.fixedListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.fixedListView.MouseState = MaterialSkin.MouseState.OUT;
            this.fixedListView.Name = "fixedListView";
            this.fixedListView.OwnerDraw = true;
            this.fixedListView.Size = new System.Drawing.Size(209, 114);
            this.fixedListView.TabIndex = 0;
            this.fixedListView.UseCompatibleStateImageBehavior = false;
            this.fixedListView.View = System.Windows.Forms.View.Details;
            this.fixedListView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.FixedListView_ItemDrag);
            this.fixedListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.FixedListView_DragDrop);
            this.fixedListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.FixedListView_DragEnter);
            this.fixedListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FixedListView_KeyUp);
            this.fixedListView.Resize += new System.EventHandler(this.FixedListView_Resize);
            // 
            // fixedListHeader
            // 
            this.fixedListHeader.Width = 204;
            // 
            // FixedMetaListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fixedListView);
            this.Name = "FixedMetaListView";
            this.Size = new System.Drawing.Size(209, 114);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader fixedListHeader;
        internal MaterialSkin.Controls.MaterialListView fixedListView;
    }
}
