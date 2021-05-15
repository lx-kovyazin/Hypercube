
namespace Hypercube.Control.FullnessMap
{
    partial class FullnessMapComponent
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
            AdamsLair.WinForms.ItemModels.ListModel<object> listModel_13 = new AdamsLair.WinForms.ItemModels.ListModel<object>();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.buildButton = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.viewPanel = new AdamsLair.WinForms.ItemViews.TiledView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mapUnitLevelSetComponent = new Hypercube.Control.FullnessMap.MapUnitLevelSetComponent();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxData
            // 
            this.textBoxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxData.Location = new System.Drawing.Point(3, 3);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ReadOnly = true;
            this.textBoxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxData.Size = new System.Drawing.Size(361, 135);
            this.textBoxData.TabIndex = 1;
            // 
            // buildButton
            // 
            this.buildButton.AutoSize = false;
            this.buildButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buildButton.Depth = 0;
            this.buildButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildButton.DrawShadows = true;
            this.buildButton.HighEmphasis = true;
            this.buildButton.Icon = null;
            this.buildButton.Location = new System.Drawing.Point(4, 512);
            this.buildButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buildButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(610, 30);
            this.buildButton.TabIndex = 2;
            this.buildButton.Text = "Построить";
            this.buildButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.buildButton.UseAccentColor = false;
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.splitContainer, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.buildButton, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(618, 548);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.viewPanel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer.Size = new System.Drawing.Size(612, 500);
            this.splitContainer.SplitterDistance = 355;
            this.splitContainer.TabIndex = 3;
            // 
            // viewPanel
            // 
            this.viewPanel.AutoScroll = true;
            this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPanel.HighlightModelItem = null;
            this.viewPanel.Location = new System.Drawing.Point(0, 0);
            this.viewPanel.Margin = new System.Windows.Forms.Padding(0);
            this.viewPanel.Model = listModel_13;
            this.viewPanel.ModelItemEditProperty = "Name";
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.RowAlignment = AdamsLair.WinForms.ItemViews.TiledView.HorizontalAlignment.Center;
            this.viewPanel.Size = new System.Drawing.Size(612, 355);
            this.viewPanel.Spacing = new System.Drawing.Size(0, 0);
            this.viewPanel.TabIndex = 0;
            this.viewPanel.TabStop = true;
            this.viewPanel.TileSize = new System.Drawing.Size(16, 16);
            this.viewPanel.UserSelectMode = AdamsLair.WinForms.ItemViews.TiledView.SelectMode.Single;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxData, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mapUnitLevelSetComponent, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(612, 141);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // mapUnitLevelSetComponent
            // 
            this.mapUnitLevelSetComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapUnitLevelSetComponent.Location = new System.Drawing.Point(370, 3);
            this.mapUnitLevelSetComponent.Name = "mapUnitLevelSetComponent";
            this.mapUnitLevelSetComponent.Size = new System.Drawing.Size(239, 135);
            this.mapUnitLevelSetComponent.TabIndex = 2;
            // 
            // FullnessMapComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "FullnessMapComponent";
            this.Size = new System.Drawing.Size(618, 548);
            this.tableLayoutPanel.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxData;
        private MaterialSkin.Controls.MaterialButton buildButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private AdamsLair.WinForms.ItemViews.TiledView viewPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MapUnitLevelSetComponent mapUnitLevelSetComponent;
    }
}
