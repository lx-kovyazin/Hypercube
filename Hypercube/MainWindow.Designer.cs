namespace Hypercube
{
	partial class MainWindow
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
			this.databaseDataView = new System.Windows.Forms.DataGridView();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.npgsqlCommand1 = new Npgsql.NpgsqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.databaseDataView)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// databaseDataView
			// 
			this.databaseDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.databaseDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.databaseDataView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.databaseDataView.Location = new System.Drawing.Point(3, 3);
			this.databaseDataView.Name = "databaseDataView";
			this.databaseDataView.ReadOnly = true;
			this.databaseDataView.Size = new System.Drawing.Size(741, 371);
			this.databaseDataView.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.databaseDataView, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(747, 377);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// npgsqlCommand1
			// 
			this.npgsqlCommand1.AllResultTypesAreUnknown = false;
			this.npgsqlCommand1.Transaction = null;
			this.npgsqlCommand1.UnknownResultTypeList = null;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(747, 377);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "MainWindow";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.databaseDataView)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView databaseDataView;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private Npgsql.NpgsqlCommand npgsqlCommand1;
	}
}

