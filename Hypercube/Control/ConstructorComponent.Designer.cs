
namespace Hypercube.Control
{
    partial class ConstructorComponent
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
            this.dimensionMetaListView = new Hypercube.Control.FixedMetaListView();
            this.measureMetaListView = new Hypercube.Control.FixedMetaListView();
            this.SuspendLayout();
            // 
            // dimensionMetaListView
            // 
            this.dimensionMetaListView.Header = "Измерение";
            this.dimensionMetaListView.Location = new System.Drawing.Point(46, 60);
            this.dimensionMetaListView.Name = "dimensionMetaListView";
            this.dimensionMetaListView.Size = new System.Drawing.Size(209, 162);
            this.dimensionMetaListView.TabIndex = 2;
            this.dimensionMetaListView.TypeName = "Hypercube.Client.Model.Hierarchy";
            // 
            // measureMetaListView
            // 
            this.measureMetaListView.Header = "Мера";
            this.measureMetaListView.Location = new System.Drawing.Point(276, 60);
            this.measureMetaListView.Name = "measureMetaListView";
            this.measureMetaListView.Size = new System.Drawing.Size(215, 162);
            this.measureMetaListView.TabIndex = 1;
            this.measureMetaListView.TypeName = "Hypercube.Client.Model.Measure";
            // 
            // ConstructorComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dimensionMetaListView);
            this.Controls.Add(this.measureMetaListView);
            this.Name = "ConstructorComponent";
            this.Size = new System.Drawing.Size(550, 433);
            this.ResumeLayout(false);

        }

        #endregion

        internal FixedMetaListView dimensionMetaListView;
        internal FixedMetaListView measureMetaListView;
    }
}
