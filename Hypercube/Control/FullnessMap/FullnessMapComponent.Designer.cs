
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
            this.viewPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.buildButton = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewPanel
            // 
            this.viewPanel.AutoScroll = true;
            this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPanel.Location = new System.Drawing.Point(3, 3);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(591, 289);
            this.viewPanel.TabIndex = 0;
            // 
            // textBoxData
            // 
            this.textBoxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxData.Location = new System.Drawing.Point(3, 298);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ReadOnly = true;
            this.textBoxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxData.Size = new System.Drawing.Size(591, 112);
            this.textBoxData.TabIndex = 1;
            // 
            // buildButton
            // 
            this.buildButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buildButton.Depth = 0;
            this.buildButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildButton.DrawShadows = true;
            this.buildButton.HighEmphasis = true;
            this.buildButton.Icon = null;
            this.buildButton.Location = new System.Drawing.Point(4, 419);
            this.buildButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buildButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(589, 37);
            this.buildButton.TabIndex = 2;
            this.buildButton.Text = "Построить";
            this.buildButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.buildButton.UseAccentColor = false;
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buildButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxData, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.viewPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(597, 462);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FullnessMapComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FullnessMapComponent";
            this.Size = new System.Drawing.Size(597, 462);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel viewPanel;
        private System.Windows.Forms.TextBox textBoxData;
        private MaterialSkin.Controls.MaterialButton buildButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
