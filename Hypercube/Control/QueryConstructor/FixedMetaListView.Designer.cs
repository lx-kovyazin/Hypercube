
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.rotateLeftButton = new MaterialSkin.Controls.MaterialButton();
            this.rotateRightButton = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel.SuspendLayout();
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
            this.tableLayoutPanel.SetColumnSpan(this.fixedListView, 2);
            this.fixedListView.Depth = 0;
            this.fixedListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fixedListView.FullRowSelect = true;
            this.fixedListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.fixedListView.HideSelection = false;
            this.fixedListView.Location = new System.Drawing.Point(0, 0);
            this.fixedListView.Margin = new System.Windows.Forms.Padding(0);
            this.fixedListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.fixedListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.fixedListView.MouseState = MaterialSkin.MouseState.OUT;
            this.fixedListView.Name = "fixedListView";
            this.fixedListView.OwnerDraw = true;
            this.fixedListView.Size = new System.Drawing.Size(213, 154);
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
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.fixedListView, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.rotateLeftButton, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.rotateRightButton, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(213, 169);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // rotateLeftButton
            // 
            this.rotateLeftButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rotateLeftButton.AutoSize = false;
            this.rotateLeftButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rotateLeftButton.Depth = 0;
            this.rotateLeftButton.DrawShadows = true;
            this.rotateLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rotateLeftButton.HighEmphasis = true;
            this.rotateLeftButton.Icon = null;
            this.rotateLeftButton.Location = new System.Drawing.Point(0, 154);
            this.rotateLeftButton.Margin = new System.Windows.Forms.Padding(0);
            this.rotateLeftButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.rotateLeftButton.Name = "rotateLeftButton";
            this.rotateLeftButton.Size = new System.Drawing.Size(106, 15);
            this.rotateLeftButton.TabIndex = 1;
            this.rotateLeftButton.Text = "⮏";
            this.rotateLeftButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.rotateLeftButton.UseAccentColor = false;
            this.rotateLeftButton.UseVisualStyleBackColor = true;
            this.rotateLeftButton.Click += new System.EventHandler(this.RotateLeftButton_Click);
            // 
            // rotateRightButton
            // 
            this.rotateRightButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rotateRightButton.AutoSize = false;
            this.rotateRightButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rotateRightButton.Depth = 0;
            this.rotateRightButton.DrawShadows = true;
            this.rotateRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rotateRightButton.HighEmphasis = true;
            this.rotateRightButton.Icon = null;
            this.rotateRightButton.Location = new System.Drawing.Point(106, 154);
            this.rotateRightButton.Margin = new System.Windows.Forms.Padding(0);
            this.rotateRightButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.rotateRightButton.Name = "rotateRightButton";
            this.rotateRightButton.Size = new System.Drawing.Size(107, 15);
            this.rotateRightButton.TabIndex = 2;
            this.rotateRightButton.Text = "⮍";
            this.rotateRightButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.rotateRightButton.UseAccentColor = false;
            this.rotateRightButton.UseVisualStyleBackColor = true;
            this.rotateRightButton.Click += new System.EventHandler(this.RotateRightButton_Click);
            // 
            // FixedMetaListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "FixedMetaListView";
            this.Size = new System.Drawing.Size(213, 169);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader fixedListHeader;
        internal MaterialSkin.Controls.MaterialListView fixedListView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private MaterialSkin.Controls.MaterialButton rotateLeftButton;
        private MaterialSkin.Controls.MaterialButton rotateRightButton;
    }
}
