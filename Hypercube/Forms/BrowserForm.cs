using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hypercube.Forms
{
    public partial class BrowserForm : MaterialSkin.Controls.MaterialForm
    {
        public BrowserForm()
        {
            InitializeComponent();
            InitializeMaterialSkinManager();

            // TODO: Not working.
            queryConstructor.DataCollected += adomdGrid.LoadDataAsync;
        }

        private void InitializeMaterialSkinManager()
        {
            // Initialize MaterialSkinManager
            var materialSkinManager = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.Pink200,
                TextShade.WHITE
            );
        }
    }
}
