using System;
using System.Windows.Forms;
using Hypercube.Client;
using Hypercube.Client.Extensions;
using HypercubeClient = Hypercube.Client.Client;

namespace Hypercube.Control
{
    public partial class ConnectionPage
        : TabPage
    {
        public ConnectionPage()
        {
            InitializeComponent();
        }

        private void LoadCatalogList()
        {
            catalogComboBox.Enabled = true;
            catalogComboBox.Items.AddRange(HypercubeClient.Instance.MetaInfo.Catalogs.ToArray());
        }

        private void LoadCubeList()
        {
            cubeComboBox.Enabled = true;
            cubeComboBox.Items.AddRange(HypercubeClient.Instance.MetaInfo.Cubes.ToArray());
        }

        private void ClearCatalogList()
        {
            if (catalogComboBox.Items.Count != 0)
            {
                catalogComboBox.Enabled = true;
                catalogComboBox.Items.Clear();
            }
        }

        private void ClearCubeList()
        {
            if (cubeComboBox.Items.Count != 0)
            {
                cubeComboBox.Enabled = true;
                cubeComboBox.Items.Clear();
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (!HypercubeClient.Instance.Connect(
                    new ConnectionString
                    {
                        Source  = serverTextBox.Text.NotMatch(string.IsNullOrEmpty)
                                                    .NotMatch(string.IsNullOrWhiteSpace),
                        Catalog = catalogComboBox.Text.NotMatch(string.IsNullOrEmpty),
                        Cube    = cubeComboBox.Text.NotMatch(string.IsNullOrEmpty)
                    }))
            {
                MessageBox.Show("An error occurred during connection!");
                return;
            }

            ClearCatalogList();
            ClearCubeList();
            LoadCatalogList();
            // TODO: Uncomment this is the future.
            //LoadFunctions();
            Cursor = Cursors.Default;
        }

        private void CatalogComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearCubeList();
            HypercubeClient.Instance.ConnectionString.Catalog = catalogComboBox.Text;
            HypercubeClient.Instance.Reconnect();
            LoadCubeList();
        }

        private void CubeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HypercubeClient.Instance.ConnectionString.Cube = cubeComboBox.Text;
            HypercubeClient.Instance.Reconnect();
        }
    }
}
