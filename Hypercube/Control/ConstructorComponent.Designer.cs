
namespace Hypercube.Control
{
    partial class ConstructorComponent
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.measureMetaListView = new Hypercube.Control.FixedMetaListView();
            this.dimensionMetaListView = new Hypercube.Control.FixedMetaListView();
            this.filterComponent = new Hypercube.Control.Filter.FilterComponent();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.measureMetaListView, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.dimensionMetaListView, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.filterComponent, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(550, 433);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // measureMetaListView
            // 
            this.measureMetaListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.measureMetaListView.Header = "Мера";
            this.measureMetaListView.Location = new System.Drawing.Point(278, 3);
            this.measureMetaListView.Name = "measureMetaListView";
            this.measureMetaListView.Size = new System.Drawing.Size(269, 221);
            this.measureMetaListView.TabIndex = 1;
            this.measureMetaListView.TypeNameList.Add("Hypercube.Client.Model.Measure");
            // 
            // dimensionMetaListView
            // 
            this.dimensionMetaListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dimensionMetaListView.Header = "Измерение";
            this.dimensionMetaListView.Location = new System.Drawing.Point(3, 3);
            this.dimensionMetaListView.Name = "dimensionMetaListView";
            this.dimensionMetaListView.Size = new System.Drawing.Size(269, 221);
            this.dimensionMetaListView.TabIndex = 2;
            this.dimensionMetaListView.TypeNameList.Add("Hypercube.Client.Model.Hierarchy");
            this.dimensionMetaListView.TypeNameList.Add("Hypercube.Client.Model.HierarchyLevel");
            // 
            // filterComponent
            // 
            this.tableLayoutPanel.SetColumnSpan(this.filterComponent, 2);
            this.filterComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterComponent.Location = new System.Drawing.Point(3, 230);
            this.filterComponent.Name = "filterComponent";
            this.filterComponent.Size = new System.Drawing.Size(544, 200);
            this.filterComponent.TabIndex = 3;
            // 
            // ConstructorComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "ConstructorComponent";
            this.Size = new System.Drawing.Size(550, 433);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal FixedMetaListView dimensionMetaListView;
        internal FixedMetaListView measureMetaListView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        public Filter.FilterComponent filterComponent;
    }
}
