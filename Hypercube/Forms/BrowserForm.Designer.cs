using Hypercube.Control;

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
            this.connectionPage = new ConnectionPage();
            this.queryConstructorPage = new QueryConstructorPage();
            this.dataSetPage = new System.Windows.Forms.TabPage();
            this.cubeView = new Hypercube.Control.CubeView();
            this.methodsPage = new MethodsPage();
            this.settingsPage = new SettingsPage();
            this.aboutPage = new AboutPage();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.mainTabControl.SuspendLayout();
            this.connectionPage.SuspendLayout();
            this.queryConstructorPage.SuspendLayout();
            this.dataSetPage.SuspendLayout();
            this.settingsPage.SuspendLayout();
            this.aboutPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.connectionPage);
            this.mainTabControl.Controls.Add(this.queryConstructorPage);
            this.mainTabControl.Controls.Add(this.dataSetPage);
            this.mainTabControl.Controls.Add(this.methodsPage);
            this.mainTabControl.Controls.Add(this.settingsPage);
            this.mainTabControl.Controls.Add(this.aboutPage);
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
            this.connectionPage.ImageKey = "ConnectionIcon.png";
            this.connectionPage.Location = new System.Drawing.Point(4, 31);
            this.connectionPage.Name = "connectionPage";
            this.connectionPage.Padding = new System.Windows.Forms.Padding(3);
            this.connectionPage.Size = new System.Drawing.Size(853, 539);
            this.connectionPage.TabIndex = 1;
            this.connectionPage.Text = "Подключение";
            this.connectionPage.UseVisualStyleBackColor = true;
            // 
            // queryConstructorPage
            // 
            this.queryConstructorPage.ImageKey = "ConstructorIcon.png";
            this.queryConstructorPage.Location = new System.Drawing.Point(4, 31);
            this.queryConstructorPage.Name = "queryConstructorPage";
            this.queryConstructorPage.Padding = new System.Windows.Forms.Padding(3);
            this.queryConstructorPage.Size = new System.Drawing.Size(853, 539);
            this.queryConstructorPage.TabIndex = 2;
            this.queryConstructorPage.Text = "Конструктор";
            this.queryConstructorPage.UseVisualStyleBackColor = true;
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
            // cubeView
            // 
            this.cubeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cubeView.FixedRows = 1;
            this.cubeView.GridToolTipActive = true;
            this.cubeView.Location = new System.Drawing.Point(3, 3);
            this.cubeView.Name = "cubeView";
            this.cubeView.Size = new System.Drawing.Size(847, 533);
            this.cubeView.SpecialKeys = ((SourceGrid3.GridSpecialKeys)(((((((SourceGrid3.GridSpecialKeys.Arrows | SourceGrid3.GridSpecialKeys.Tab) 
            | SourceGrid3.GridSpecialKeys.PageDownUp) 
            | SourceGrid3.GridSpecialKeys.Enter) 
            | SourceGrid3.GridSpecialKeys.Escape) 
            | SourceGrid3.GridSpecialKeys.Control) 
            | SourceGrid3.GridSpecialKeys.Shift)));
            this.cubeView.StyleGrid = null;
            this.cubeView.TabIndex = 0;
            // 
            // methodsPage
            // 
            this.methodsPage.ImageKey = "MethodIcon.png";
            this.methodsPage.Location = new System.Drawing.Point(4, 31);
            this.methodsPage.Name = "methodsPage";
            this.methodsPage.Padding = new System.Windows.Forms.Padding(3);
            this.methodsPage.Size = new System.Drawing.Size(853, 539);
            this.methodsPage.TabIndex = 5;
            this.methodsPage.Text = "Методы";
            this.methodsPage.UseVisualStyleBackColor = true;
            // 
            // settingsPage
            // 
            this.settingsPage.ImageKey = "SettingsIcon.png";
            this.settingsPage.Location = new System.Drawing.Point(4, 31);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsPage.Size = new System.Drawing.Size(853, 539);
            this.settingsPage.TabIndex = 3;
            this.settingsPage.Text = "Настройки";
            this.settingsPage.UseVisualStyleBackColor = true;
            // 
            // aboutPage
            // 
            this.aboutPage.ImageKey = "AboutIcon.png";
            this.aboutPage.Location = new System.Drawing.Point(4, 31);
            this.aboutPage.Name = "aboutPage";
            this.aboutPage.Padding = new System.Windows.Forms.Padding(3);
            this.aboutPage.Size = new System.Drawing.Size(853, 539);
            this.aboutPage.TabIndex = 0;
            this.aboutPage.Text = "О программе";
            this.aboutPage.UseVisualStyleBackColor = true;
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
            this.imageList.Images.SetKeyName(5, "MethodIcon.png");
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
            this.queryConstructorPage.ResumeLayout(false);
            this.dataSetPage.ResumeLayout(false);
            this.settingsPage.ResumeLayout(false);
            this.aboutPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mainTabControl;
        private AboutPage aboutPage;
        private ConnectionPage connectionPage;
        private QueryConstructorPage queryConstructorPage;
        private SettingsPage settingsPage;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TabPage dataSetPage;
        private MethodsPage methodsPage;
        private Control.CubeView cubeView;
    }
}
