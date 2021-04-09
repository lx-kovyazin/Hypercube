using Microsoft.AnalysisServices.AdomdClient;
using System;
using System.Windows.Forms;


namespace Hypercube
{
    public partial class Command : Form
    {

        private AdomdConnection moConn;
        private CubeDef moCube;

        public Command()
        {
            InitializeComponent();
        }

        public AdomdConnection Connection
        {
            get => moConn;
            set => moConn = value;
        }

        public CubeDef Cube
        {
            get => moCube;
            set { moCube = value; LoadData(); }
        }

        private void LoadData()
        {
            adomdDimTree1.Cube = moCube;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ExecuteCommandDataSet();
        }

        private void ExecuteCommandDataSet()
        {
            string sMDX = txtMDX.Text;

            try
            {
                AdomdCommand oCmd = new AdomdCommand(sMDX, moConn);

                AdomdDataAdapter da = new AdomdDataAdapter(oCmd);

                //DataSet ds = new DataSet();

                da.Fill(dataSet1, "olap");

                grdResults.LoadData(dataSet1.Tables["olap"]);
                //grdResults.DataSource = dataSet1.Tables["olap"];


            }
            catch (AdomdException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ExecuteCommandReader();
        }

        private void ExecuteCommandReader()
        {
            string sMDX = txtMDX.Text;

            try
            {
                AdomdCommand oCmd = new AdomdCommand(sMDX, moConn);

                using (AdomdDataReader oReader = oCmd.ExecuteReader())
                {
                    grdResults.LoadData(oReader);
                }
            }
            catch (AdomdException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ExecuteCommandCellSet();
        }

        private void ExecuteCommandCellSet()
        {
            string sMDX = txtMDX.Text;

            try
            {
                AdomdCommand oCmd = new AdomdCommand(sMDX, moConn);

                CellSet set = oCmd.ExecuteCellSet();
                grdResults.LoadData(set);
            }
            catch (AdomdException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}