
namespace Hypercube.Control
{
    partial class CubeTreeComponent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CubeTreeComponent));
            this.cubeTreeView = new System.Windows.Forms.TreeView();
            this.cubeTreeViewImageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // cubeTreeView
            // 
            this.cubeTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cubeTreeView.ImageIndex = 0;
            this.cubeTreeView.ImageList = this.cubeTreeViewImageList;
            this.cubeTreeView.Location = new System.Drawing.Point(0, 0);
            this.cubeTreeView.Name = "cubeTreeView";
            this.cubeTreeView.SelectedImageKey = "Cube.bmp";
            this.cubeTreeView.Size = new System.Drawing.Size(207, 512);
            this.cubeTreeView.TabIndex = 0;
            this.cubeTreeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.CubeTreeView_ItemDrag);
            // 
            // cubeTreeViewImageList
            // 
            this.cubeTreeViewImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("cubeTreeViewImageList.ImageStream")));
            this.cubeTreeViewImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.cubeTreeViewImageList.Images.SetKeyName(0, "CubeIcon.png");
            this.cubeTreeViewImageList.Images.SetKeyName(1, "MeasureIcon.png");
            this.cubeTreeViewImageList.Images.SetKeyName(2, "DimensionIcon.png");
            this.cubeTreeViewImageList.Images.SetKeyName(3, "AttributeHierarchyIcon.png");
            this.cubeTreeViewImageList.Images.SetKeyName(4, "UserHierarchyIcon.png");
            // 
            // CubeTreeComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cubeTreeView);
            this.Name = "CubeTreeComponent";
            this.Size = new System.Drawing.Size(207, 512);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView cubeTreeView;
        private System.Windows.Forms.ImageList cubeTreeViewImageList;
    }
}
