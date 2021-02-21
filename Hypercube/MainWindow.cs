using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Database;

namespace Hypercube
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		public void SetGridData(List<User> users)
		{
			databaseDataView.RowCount = users.Count();
			databaseDataView.ColumnCount = User.numOfFields;
			databaseDataView.Columns[0].HeaderText = "Id";
			databaseDataView.Columns[1].HeaderText = "Name";
			databaseDataView.Columns[2].HeaderText = "Age";

			databaseDataView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			foreach (DataGridViewColumn column in databaseDataView.Columns)
			{
				column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			}

			foreach (User user in users)
			{
				databaseDataView.Rows[user.Id - 1].Cells[0].Value = user.Id;
				databaseDataView.Rows[user.Id - 1].Cells[1].Value = user.Name;
				databaseDataView.Rows[user.Id - 1].Cells[2].Value = user.Age;
			}
		}
	}
}
