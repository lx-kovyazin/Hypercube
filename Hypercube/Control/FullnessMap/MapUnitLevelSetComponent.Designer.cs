
namespace Hypercube.Control.FullnessMap
{
    partial class MapUnitLevelSetComponent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapUnitLevelSetComponent));
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.mapUnitLevelSet = new Hypercube.Control.FullnessMap.MapUnitLevelSet();
            this.levelHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colorPanel = new AdamsLair.WinForms.ColorControls.ColorPanel();
            this.percentUpDown = new System.Windows.Forms.NumericUpDown();
            this.addButton = new MaterialSkin.Controls.MaterialButton();
            this.tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Controls.Add(this.materialLabel, 0, 0);
            this.tableLayout.Controls.Add(this.mapUnitLevelSet, 0, 1);
            this.tableLayout.Controls.Add(this.colorPanel, 1, 1);
            this.tableLayout.Controls.Add(this.percentUpDown, 1, 2);
            this.tableLayout.Controls.Add(this.addButton, 1, 3);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 4;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout.Size = new System.Drawing.Size(311, 184);
            this.tableLayout.TabIndex = 0;
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.tableLayout.SetColumnSpan(this.materialLabel, 2);
            this.materialLabel.Depth = 0;
            this.materialLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel.Location = new System.Drawing.Point(3, 0);
            this.materialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(305, 19);
            this.materialLabel.TabIndex = 5;
            this.materialLabel.Text = "Зафиксировать уровень";
            // 
            // mapUnitLevelSet
            // 
            this.mapUnitLevelSet.AutoArrange = false;
            this.mapUnitLevelSet.AutoSizeTable = false;
            this.mapUnitLevelSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mapUnitLevelSet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mapUnitLevelSet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.levelHeader});
            this.mapUnitLevelSet.Depth = 0;
            this.mapUnitLevelSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapUnitLevelSet.FullRowSelect = true;
            this.mapUnitLevelSet.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mapUnitLevelSet.HideSelection = false;
            this.mapUnitLevelSet.Location = new System.Drawing.Point(0, 19);
            this.mapUnitLevelSet.Margin = new System.Windows.Forms.Padding(0);
            this.mapUnitLevelSet.MinimumSize = new System.Drawing.Size(50, 50);
            this.mapUnitLevelSet.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mapUnitLevelSet.MouseState = MaterialSkin.MouseState.OUT;
            this.mapUnitLevelSet.MultiSelect = false;
            this.mapUnitLevelSet.Name = "mapUnitLevelSet";
            this.mapUnitLevelSet.OwnerDraw = true;
            this.tableLayout.SetRowSpan(this.mapUnitLevelSet, 3);
            this.mapUnitLevelSet.Size = new System.Drawing.Size(70, 165);
            this.mapUnitLevelSet.TabIndex = 6;
            this.mapUnitLevelSet.UseCompatibleStateImageBehavior = false;
            this.mapUnitLevelSet.View = System.Windows.Forms.View.Details;
            // 
            // levelHeader
            // 
            this.levelHeader.Text = "Уровень";
            this.levelHeader.Width = 70;
            // 
            // colorPanel
            // 
            this.colorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPanel.Location = new System.Drawing.Point(70, 19);
            this.colorPanel.Margin = new System.Windows.Forms.Padding(0);
            this.colorPanel.MinimumSize = new System.Drawing.Size(80, 30);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(241, 125);
            this.colorPanel.TabIndex = 0;
            this.colorPanel.Text = "colorPanel1";
            this.colorPanel.ValuePercentual = ((System.Drawing.PointF)(resources.GetObject("colorPanel.ValuePercentual")));
            // 
            // percentUpDown
            // 
            this.percentUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.percentUpDown.Location = new System.Drawing.Point(70, 144);
            this.percentUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.percentUpDown.Name = "percentUpDown";
            this.percentUpDown.Size = new System.Drawing.Size(241, 20);
            this.percentUpDown.TabIndex = 3;
            this.percentUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addButton
            // 
            this.addButton.AutoSize = false;
            this.addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton.Depth = 0;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.DrawShadows = true;
            this.addButton.HighEmphasis = true;
            this.addButton.Icon = null;
            this.addButton.Location = new System.Drawing.Point(70, 164);
            this.addButton.Margin = new System.Windows.Forms.Padding(0);
            this.addButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(241, 20);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.addButton.UseAccentColor = false;
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // MapUnitLevelSetComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayout);
            this.Name = "MapUnitLevelSetComponent";
            this.Size = new System.Drawing.Size(311, 184);
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private AdamsLair.WinForms.ColorControls.ColorPanel colorPanel;
        private MaterialSkin.Controls.MaterialButton addButton;
        private System.Windows.Forms.NumericUpDown percentUpDown;
        private MaterialSkin.Controls.MaterialLabel materialLabel;
        public MapUnitLevelSet mapUnitLevelSet;
        private System.Windows.Forms.ColumnHeader levelHeader;
    }
}
