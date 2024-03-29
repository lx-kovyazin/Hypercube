﻿
namespace Hypercube.Control
{
    partial class ConnectionPage
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
            this.connectButton = new MaterialSkin.Controls.MaterialButton();
            this.serverTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.catalogComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.cubeComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.connectionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connectButton.Depth = 0;
            this.connectButton.DrawShadows = true;
            this.connectButton.HighEmphasis = true;
            this.connectButton.Icon = null;
            this.connectButton.Location = new System.Drawing.Point(319, 103);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.connectButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(144, 36);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Подключиться";
            this.connectButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.connectButton.UseAccentColor = false;
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // serverTextBox
            // 
            this.serverTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serverTextBox.Depth = 0;
            this.serverTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.serverTextBox.Hint = "Cервер";
            this.serverTextBox.Location = new System.Drawing.Point(45, 96);
            this.serverTextBox.MaxLength = 50;
            this.serverTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.serverTextBox.Multiline = false;
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(267, 50);
            this.serverTextBox.TabIndex = 1;
            this.serverTextBox.Text = "";
            // 
            // catalogComboBox
            // 
            this.catalogComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.catalogComboBox.AutoResize = false;
            this.catalogComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.catalogComboBox.Depth = 0;
            this.catalogComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.catalogComboBox.DropDownHeight = 174;
            this.catalogComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catalogComboBox.DropDownWidth = 121;
            this.catalogComboBox.Enabled = false;
            this.catalogComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.catalogComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.catalogComboBox.FormattingEnabled = true;
            this.catalogComboBox.Hint = "Каталог";
            this.catalogComboBox.IntegralHeight = false;
            this.catalogComboBox.ItemHeight = 43;
            this.catalogComboBox.Location = new System.Drawing.Point(45, 152);
            this.catalogComboBox.MaxDropDownItems = 4;
            this.catalogComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.catalogComboBox.Name = "catalogComboBox";
            this.catalogComboBox.Size = new System.Drawing.Size(267, 49);
            this.catalogComboBox.StartIndex = 0;
            this.catalogComboBox.TabIndex = 4;
            this.catalogComboBox.SelectedIndexChanged += new System.EventHandler(this.CatalogComboBox_SelectedIndexChanged);
            // 
            // cubeComboBox
            // 
            this.cubeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cubeComboBox.AutoResize = false;
            this.cubeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cubeComboBox.Depth = 0;
            this.cubeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cubeComboBox.DropDownHeight = 174;
            this.cubeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cubeComboBox.DropDownWidth = 121;
            this.cubeComboBox.Enabled = false;
            this.cubeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cubeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cubeComboBox.FormattingEnabled = true;
            this.cubeComboBox.Hint = "Гиперкуб";
            this.cubeComboBox.IntegralHeight = false;
            this.cubeComboBox.ItemHeight = 43;
            this.cubeComboBox.Location = new System.Drawing.Point(45, 207);
            this.cubeComboBox.MaxDropDownItems = 4;
            this.cubeComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.cubeComboBox.Name = "cubeComboBox";
            this.cubeComboBox.Size = new System.Drawing.Size(267, 49);
            this.cubeComboBox.StartIndex = 0;
            this.cubeComboBox.TabIndex = 4;
            this.cubeComboBox.SelectedIndexChanged += new System.EventHandler(this.CubeComboBox_SelectedIndexChanged);
            // 
            // connectionLabel
            // 
            this.connectionLabel.AutoSize = true;
            this.connectionLabel.Depth = 0;
            this.connectionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.connectionLabel.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.connectionLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.connectionLabel.Location = new System.Drawing.Point(0, 0);
            this.connectionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(593, 58);
            this.connectionLabel.TabIndex = 5;
            this.connectionLabel.Text = "Подключение к гиперкубу";
            // 
            // ConnectionPage
            // 
            this.Controls.Add(this.connectionLabel);
            this.Controls.Add(this.serverTextBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.catalogComboBox);
            this.Controls.Add(this.cubeComboBox);
            this.Name = "ConnectionPage";
            this.Size = new System.Drawing.Size(640, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton connectButton;
        private MaterialSkin.Controls.MaterialTextBox serverTextBox;
        private MaterialSkin.Controls.MaterialComboBox catalogComboBox;
        private MaterialSkin.Controls.MaterialComboBox cubeComboBox;
        private MaterialSkin.Controls.MaterialLabel connectionLabel;
    }
}
