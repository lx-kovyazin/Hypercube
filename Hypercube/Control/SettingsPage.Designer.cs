
namespace Hypercube.Control
{
    partial class SettingsPage
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
            this.executionMethodSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.executionMethodLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // executionMethodSwitch
            // 
            this.executionMethodSwitch.AutoSize = true;
            this.executionMethodSwitch.Depth = 0;
            this.executionMethodSwitch.Location = new System.Drawing.Point(44, 63);
            this.executionMethodSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.executionMethodSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.executionMethodSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.executionMethodSwitch.Name = "executionMethodSwitch";
            this.executionMethodSwitch.Ripple = true;
            this.executionMethodSwitch.Size = new System.Drawing.Size(228, 37);
            this.executionMethodSwitch.TabIndex = 0;
            this.executionMethodSwitch.Text = "executionMethodSwitch";
            this.executionMethodSwitch.UseVisualStyleBackColor = true;
            // 
            // executionMethodLabel
            // 
            this.executionMethodLabel.AutoSize = true;
            this.executionMethodLabel.Depth = 0;
            this.executionMethodLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.executionMethodLabel.Location = new System.Drawing.Point(41, 35);
            this.executionMethodLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.executionMethodLabel.Name = "executionMethodLabel";
            this.executionMethodLabel.Size = new System.Drawing.Size(280, 19);
            this.executionMethodLabel.TabIndex = 1;
            this.executionMethodLabel.Text = "Выбор способа выполнения запроса:";
            // 
            // SettingsPage
            // 
            this.Controls.Add(this.executionMethodLabel);
            this.Controls.Add(this.executionMethodSwitch);
            this.Name = "SettingsPage";
            this.Size = new System.Drawing.Size(616, 444);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MaterialSkin.Controls.MaterialSwitch executionMethodSwitch;
        private MaterialSkin.Controls.MaterialLabel executionMethodLabel;
    }
}
