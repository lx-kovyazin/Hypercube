namespace Hypercube.Control.Filter
{
    partial class FilterComponent
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
            this.setupFilterLabel = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.filterListView = new Hypercube.Control.Filter.FilterListView();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // setupFilterLabel
            // 
            this.setupFilterLabel.AutoSize = true;
            this.setupFilterLabel.Depth = 0;
            this.setupFilterLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.setupFilterLabel.Location = new System.Drawing.Point(3, 0);
            this.setupFilterLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.setupFilterLabel.Name = "setupFilterLabel";
            this.setupFilterLabel.Size = new System.Drawing.Size(116, 19);
            this.setupFilterLabel.TabIndex = 0;
            this.setupFilterLabel.Text = "Задать фильтр";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.setupFilterLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.filterListView, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(640, 200);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // filterListView
            // 
            this.filterListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterListView.HideSelection = false;
            this.filterListView.Location = new System.Drawing.Point(3, 22);
            this.filterListView.Name = "filterListView";
            this.filterListView.Size = new System.Drawing.Size(634, 175);
            this.filterListView.TabIndex = 1;
            this.filterListView.UseCompatibleStateImageBehavior = false;
            // 
            // FilterComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "FilterComponent";
            this.Size = new System.Drawing.Size(640, 200);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel setupFilterLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private FilterListView filterListView;
    }
}
