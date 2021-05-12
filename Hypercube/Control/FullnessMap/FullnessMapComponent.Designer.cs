
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
			this.btnShow = new MaterialSkin.Controls.MaterialButton();
			this.SuspendLayout();
			// 
			// viewPanel
			// 
			this.viewPanel.AutoScroll = true;
			this.viewPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.viewPanel.Location = new System.Drawing.Point(0, 0);
			this.viewPanel.Name = "viewPanel";
			this.viewPanel.Size = new System.Drawing.Size(597, 249);
			this.viewPanel.TabIndex = 0;
			// 
			// textBoxData
			// 
			this.textBoxData.Location = new System.Drawing.Point(0, 255);
			this.textBoxData.Multiline = true;
			this.textBoxData.Name = "textBoxData";
			this.textBoxData.ReadOnly = true;
			this.textBoxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxData.Size = new System.Drawing.Size(597, 156);
			this.textBoxData.TabIndex = 1;
			// 
			// btnShow
			// 
			this.btnShow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnShow.Depth = 0;
			this.btnShow.DrawShadows = true;
			this.btnShow.HighEmphasis = true;
			this.btnShow.Icon = null;
			this.btnShow.Location = new System.Drawing.Point(495, 420);
			this.btnShow.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnShow.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(98, 36);
			this.btnShow.TabIndex = 2;
			this.btnShow.Text = "Показать";
			this.btnShow.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.btnShow.UseAccentColor = false;
			this.btnShow.UseVisualStyleBackColor = true;
			this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
			// 
			// FullnessMapComponent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnShow);
			this.Controls.Add(this.textBoxData);
			this.Controls.Add(this.viewPanel);
			this.Name = "FullnessMapComponent";
			this.Size = new System.Drawing.Size(597, 462);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel viewPanel;
        private System.Windows.Forms.TextBox textBoxData;
        private MaterialSkin.Controls.MaterialButton btnShow;
    }
}
