
namespace Hypercube.Control
{
    partial class QueryConstructor
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.constructorTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.constructorTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.constructorTabPage = new System.Windows.Forms.TabPage();
            this.constructorComponent = new Hypercube.Control.ConstructorComponent();
            this.queryTabPage = new System.Windows.Forms.TabPage();
            this.commandComponent = new Hypercube.Control.CommandComponent();
            this.cubeTreeComponent = new Hypercube.Control.CubeTreeComponent();
            this.executeButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.constructorTabControl.SuspendLayout();
            this.constructorTabPage.SuspendLayout();
            this.queryTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.constructorTabSelector);
            this.splitContainer1.Panel1.Controls.Add(this.constructorTabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cubeTreeComponent);
            this.splitContainer1.Panel2.Controls.Add(this.executeButton);
            this.splitContainer1.Size = new System.Drawing.Size(640, 480);
            this.splitContainer1.SplitterDistance = 463;
            this.splitContainer1.TabIndex = 0;
            // 
            // constructorTabSelector
            // 
            this.constructorTabSelector.BaseTabControl = this.constructorTabControl;
            this.constructorTabSelector.Depth = 0;
            this.constructorTabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.constructorTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.constructorTabSelector.Location = new System.Drawing.Point(0, 0);
            this.constructorTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.constructorTabSelector.Name = "constructorTabSelector";
            this.constructorTabSelector.Size = new System.Drawing.Size(463, 30);
            this.constructorTabSelector.TabIndex = 0;
            this.constructorTabSelector.TabIndicatorHeight = 3;
            this.constructorTabSelector.Text = "constructorTabSelector";
            // 
            // constructorTabControl
            // 
            this.constructorTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.constructorTabControl.Controls.Add(this.constructorTabPage);
            this.constructorTabControl.Controls.Add(this.queryTabPage);
            this.constructorTabControl.Depth = 0;
            this.constructorTabControl.Location = new System.Drawing.Point(3, 36);
            this.constructorTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.constructorTabControl.Multiline = true;
            this.constructorTabControl.Name = "constructorTabControl";
            this.constructorTabControl.Padding = new System.Drawing.Point(3, 6);
            this.constructorTabControl.SelectedIndex = 0;
            this.constructorTabControl.Size = new System.Drawing.Size(457, 441);
            this.constructorTabControl.TabIndex = 0;
            this.constructorTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.ConstructorTabControl_Selected);
            // 
            // constructorTabPage
            // 
            this.constructorTabPage.Controls.Add(this.constructorComponent);
            this.constructorTabPage.Location = new System.Drawing.Point(4, 28);
            this.constructorTabPage.Name = "constructorTabPage";
            this.constructorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.constructorTabPage.Size = new System.Drawing.Size(449, 409);
            this.constructorTabPage.TabIndex = 0;
            this.constructorTabPage.Text = "Конструктор";
            this.constructorTabPage.UseVisualStyleBackColor = true;
            // 
            // constructorComponent
            // 
            this.constructorComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constructorComponent.Location = new System.Drawing.Point(3, 3);
            this.constructorComponent.Margin = new System.Windows.Forms.Padding(0);
            this.constructorComponent.Name = "constructorComponent";
            this.constructorComponent.Size = new System.Drawing.Size(443, 403);
            this.constructorComponent.TabIndex = 0;
            // 
            // queryTabPage
            // 
            this.queryTabPage.Controls.Add(this.commandComponent);
            this.queryTabPage.Location = new System.Drawing.Point(4, 28);
            this.queryTabPage.Name = "queryTabPage";
            this.queryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.queryTabPage.Size = new System.Drawing.Size(449, 409);
            this.queryTabPage.TabIndex = 1;
            this.queryTabPage.Text = "Запрос";
            this.queryTabPage.UseVisualStyleBackColor = true;
            // 
            // commandComponent
            // 
            this.commandComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandComponent.Location = new System.Drawing.Point(3, 3);
            this.commandComponent.Name = "commandComponent";
            this.commandComponent.Size = new System.Drawing.Size(443, 403);
            this.commandComponent.TabIndex = 0;
            // 
            // cubeTreeComponent
            // 
            this.cubeTreeComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cubeTreeComponent.Location = new System.Drawing.Point(3, 3);
            this.cubeTreeComponent.Name = "cubeTreeComponent";
            this.cubeTreeComponent.Size = new System.Drawing.Size(167, 429);
            this.cubeTreeComponent.TabIndex = 3;
            // 
            // executeButton
            // 
            this.executeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.executeButton.AutoSize = false;
            this.executeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.executeButton.Depth = 0;
            this.executeButton.DrawShadows = true;
            this.executeButton.HighEmphasis = true;
            this.executeButton.Icon = null;
            this.executeButton.Location = new System.Drawing.Point(4, 441);
            this.executeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.executeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(165, 36);
            this.executeButton.TabIndex = 1;
            this.executeButton.Text = "Выполнить";
            this.executeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.executeButton.UseAccentColor = false;
            this.executeButton.UseVisualStyleBackColor = true;

            // 
            // QueryConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "QueryConstructor";
            this.Size = new System.Drawing.Size(640, 480);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.constructorTabControl.ResumeLayout(false);
            this.constructorTabPage.ResumeLayout(false);
            this.queryTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialTabControl constructorTabControl;
        private System.Windows.Forms.TabPage constructorTabPage;
        private System.Windows.Forms.TabPage queryTabPage;
        private ConstructorComponent constructorComponent;
        private CommandComponent commandComponent;
        private MaterialSkin.Controls.MaterialTabSelector constructorTabSelector;
        private CubeTreeComponent cubeTreeComponent;
        private MaterialSkin.Controls.MaterialButton executeButton;
    }
}
