namespace Hypercube.Control
{
    partial class MethodsPage
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
            this.methodTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.methodlTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.fullnessMapTabPage = new System.Windows.Forms.TabPage();
            this.fullnessMapComponent = new Hypercube.Control.FullnessMap.FullnessMapComponent();
            this.methodlTabControl.SuspendLayout();
            this.fullnessMapTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // methodTabSelector
            // 
            this.methodTabSelector.BaseTabControl = this.methodlTabControl;
            this.methodTabSelector.Depth = 0;
            this.methodTabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.methodTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.methodTabSelector.Location = new System.Drawing.Point(0, 0);
            this.methodTabSelector.Margin = new System.Windows.Forms.Padding(0);
            this.methodTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.methodTabSelector.Name = "methodTabSelector";
            this.methodTabSelector.Size = new System.Drawing.Size(640, 30);
            this.methodTabSelector.TabIndex = 0;
            this.methodTabSelector.TabIndicatorHeight = 1;
            this.methodTabSelector.Text = "methodTabSelector";
            // 
            // methodlTabControl
            // 
            this.methodlTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.methodlTabControl.Controls.Add(this.fullnessMapTabPage);
            this.methodlTabControl.Depth = 0;
            this.methodlTabControl.Location = new System.Drawing.Point(0, 30);
            this.methodlTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.methodlTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.methodlTabControl.Multiline = true;
            this.methodlTabControl.Name = "methodlTabControl";
            this.methodlTabControl.Padding = new System.Drawing.Point(0, 0);
            this.methodlTabControl.SelectedIndex = 0;
            this.methodlTabControl.Size = new System.Drawing.Size(640, 450);
            this.methodlTabControl.TabIndex = 1;
            // 
            // fullnessMapTabPage
            // 
            this.fullnessMapTabPage.Controls.Add(this.fullnessMapComponent);
            this.fullnessMapTabPage.Location = new System.Drawing.Point(4, 22);
            this.fullnessMapTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.fullnessMapTabPage.Name = "fullnessMapTabPage";
            this.fullnessMapTabPage.Size = new System.Drawing.Size(632, 424);
            this.fullnessMapTabPage.TabIndex = 0;
            this.fullnessMapTabPage.Text = "Карта заполненности";
            this.fullnessMapTabPage.UseVisualStyleBackColor = true;
            // 
            // fullnessMapComponent
            // 
            this.fullnessMapComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullnessMapComponent.Location = new System.Drawing.Point(0, 0);
            this.fullnessMapComponent.Name = "fullnessMapComponent";
            this.fullnessMapComponent.Size = new System.Drawing.Size(632, 424);
            this.fullnessMapComponent.TabIndex = 0;
            // 
            // MethodsPage
            // 
            this.Controls.Add(this.methodTabSelector);
            this.Controls.Add(this.methodlTabControl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MethodsPage";
            this.Size = new System.Drawing.Size(640, 480);
            this.methodlTabControl.ResumeLayout(false);
            this.fullnessMapTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector methodTabSelector;
        public MaterialSkin.Controls.MaterialTabControl methodlTabControl;
        public System.Windows.Forms.TabPage fullnessMapTabPage;
        public FullnessMap.FullnessMapComponent fullnessMapComponent;
    }
}
