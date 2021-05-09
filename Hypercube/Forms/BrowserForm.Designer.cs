namespace Hypercube.Forms
{
    partial class BrowserForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserForm));
            this.mainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.connectionPage = new System.Windows.Forms.TabPage();
            this.connectionComponent = new Hypercube.Control.ConnectionComponent();
            this.constructorTabPage = new System.Windows.Forms.TabPage();
            this.queryConstructor = new Hypercube.Control.QueryConstructor();
            this.dataSetPage = new System.Windows.Forms.TabPage();
            this.methodsPage = new System.Windows.Forms.TabPage();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.settingsComponent = new Hypercube.Control.SettingsComponent();
            this.aboutTabPage = new System.Windows.Forms.TabPage();
            this.aboutComponent = new Hypercube.Control.AboutComponent();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.cubeView = new Hypercube.Control.CubeView();
            this.mainTabControl.SuspendLayout();
            this.connectionPage.SuspendLayout();
            this.constructorTabPage.SuspendLayout();
            this.dataSetPage.SuspendLayout();
            this.methodsPage.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            this.aboutTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.connectionPage);
            this.mainTabControl.Controls.Add(this.constructorTabPage);
            this.mainTabControl.Controls.Add(this.dataSetPage);
            this.mainTabControl.Controls.Add(this.methodsPage);
            this.mainTabControl.Controls.Add(this.settingsTabPage);
            this.mainTabControl.Controls.Add(this.aboutTabPage);
            this.mainTabControl.Depth = 0;
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.ImageList = this.imageList;
            this.mainTabControl.Location = new System.Drawing.Point(3, 3);
            this.mainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(861, 574);
            this.mainTabControl.TabIndex = 0;
            // 
            // connectionPage
            // 
            this.connectionPage.Controls.Add(this.connectionComponent);
            this.connectionPage.ImageKey = "ConnectionIcon.png";
            this.connectionPage.Location = new System.Drawing.Point(4, 31);
            this.connectionPage.Name = "connectionPage";
            this.connectionPage.Padding = new System.Windows.Forms.Padding(3);
            this.connectionPage.Size = new System.Drawing.Size(853, 539);
            this.connectionPage.TabIndex = 1;
            this.connectionPage.Text = "Подключение";
            this.connectionPage.UseVisualStyleBackColor = true;
            // 
            // connectionComponent
            // 
            this.connectionComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionComponent.Location = new System.Drawing.Point(3, 3);
            this.connectionComponent.Name = "connectionComponent";
            this.connectionComponent.Size = new System.Drawing.Size(847, 533);
            this.connectionComponent.TabIndex = 0;
            // 
            // constructorTabPage
            // 
            this.constructorTabPage.Controls.Add(this.queryConstructor);
            this.constructorTabPage.ImageKey = "ConstructorIcon.png";
            this.constructorTabPage.Location = new System.Drawing.Point(4, 31);
            this.constructorTabPage.Name = "constructorTabPage";
            this.constructorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.constructorTabPage.Size = new System.Drawing.Size(853, 539);
            this.constructorTabPage.TabIndex = 2;
            this.constructorTabPage.Text = "Конструктор";
            this.constructorTabPage.UseVisualStyleBackColor = true;
            // 
            // queryConstructor
            // 
            this.queryConstructor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryConstructor.Location = new System.Drawing.Point(3, 3);
            this.queryConstructor.Name = "queryConstructor";
            this.queryConstructor.Size = new System.Drawing.Size(847, 533);
            this.queryConstructor.TabIndex = 0;
            // 
            // dataSetPage
            // 
            this.dataSetPage.Controls.Add(this.cubeView);
            this.dataSetPage.ImageKey = "DataSetIcon.png";
            this.dataSetPage.Location = new System.Drawing.Point(4, 31);
            this.dataSetPage.Name = "dataSetPage";
            this.dataSetPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataSetPage.Size = new System.Drawing.Size(853, 539);
            this.dataSetPage.TabIndex = 4;
            this.dataSetPage.Text = "Данные";
            this.dataSetPage.UseVisualStyleBackColor = true;
            // 
            // methodsPage
            // 
            this.methodsPage.Location = new System.Drawing.Point(4, 31);
            this.methodsPage.Name = "methodsPage";
            this.methodsPage.Padding = new System.Windows.Forms.Padding(3);
            this.methodsPage.Size = new System.Drawing.Size(853, 539);
            this.methodsPage.TabIndex = 5;
            this.methodsPage.Text = "Методы";
            this.methodsPage.UseVisualStyleBackColor = true;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.settingsComponent);
            this.settingsTabPage.ImageKey = "SettingsIcon.png";
            this.settingsTabPage.Location = new System.Drawing.Point(4, 31);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTabPage.Size = new System.Drawing.Size(853, 539);
            this.settingsTabPage.TabIndex = 3;
            this.settingsTabPage.Text = "Настройки";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // settingsComponent
            // 
            this.settingsComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsComponent.Location = new System.Drawing.Point(3, 3);
            this.settingsComponent.Name = "settingsComponent";
            this.settingsComponent.Size = new System.Drawing.Size(847, 533);
            this.settingsComponent.TabIndex = 0;
            // 
            // aboutTabPage
            // 
            this.aboutTabPage.Controls.Add(this.aboutComponent);
            this.aboutTabPage.ImageKey = "AboutIcon.png";
            this.aboutTabPage.Location = new System.Drawing.Point(4, 31);
            this.aboutTabPage.Name = "aboutTabPage";
            this.aboutTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.aboutTabPage.Size = new System.Drawing.Size(853, 539);
            this.aboutTabPage.TabIndex = 0;
            this.aboutTabPage.Text = "О программе";
            this.aboutTabPage.UseVisualStyleBackColor = true;
            // 
            // aboutComponent
            // 
            this.aboutComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutComponent.Location = new System.Drawing.Point(3, 3);
            this.aboutComponent.Name = "aboutComponent";
            this.aboutComponent.Size = new System.Drawing.Size(847, 533);
            this.aboutComponent.TabIndex = 0;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "ConnectionIcon.png");
            this.imageList.Images.SetKeyName(1, "ConstructorIcon.png");
            this.imageList.Images.SetKeyName(2, "SettingsIcon.png");
            this.imageList.Images.SetKeyName(3, "AboutIcon.png");
            this.imageList.Images.SetKeyName(4, "DataSetIcon.png");
            // 
            // cubeView1
            // 
            this.cubeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cubeView.Location = new System.Drawing.Point(3, 3);
            this.cubeView.Name = "cubeView";
            this.cubeView.Size = new System.Drawing.Size(847, 533);
            this.cubeView.TabIndex = 0;
            // 
            // BrowserForm
            // 
            this.ClientSize = new System.Drawing.Size(867, 580);
            this.Controls.Add(this.mainTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.mainTabControl;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "BrowserForm";
            this.Text = "Hypercube";
            this.mainTabControl.ResumeLayout(false);
            this.connectionPage.ResumeLayout(false);
            this.constructorTabPage.ResumeLayout(false);
            this.dataSetPage.ResumeLayout(false);
            this.methodsPage.ResumeLayout(false);
            this.settingsTabPage.ResumeLayout(false);
            this.aboutTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mainTabControl;
        private System.Windows.Forms.TabPage aboutTabPage;
        private Control.AboutComponent aboutComponent;
        private System.Windows.Forms.TabPage connectionPage;
        private System.Windows.Forms.TabPage constructorTabPage;
        private System.Windows.Forms.TabPage settingsTabPage;
        private Control.ConnectionComponent connectionComponent;
        private Control.QueryConstructor queryConstructor;
        private Control.SettingsComponent settingsComponent;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TabPage dataSetPage;
        private System.Windows.Forms.TabPage methodsPage;
        private Control.CubeView cubeView;
    }
}
