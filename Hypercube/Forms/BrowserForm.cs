using MaterialSkin;
using MaterialSkin.Controls;

namespace Hypercube.Forms
{
    public partial class BrowserForm
        : MaterialForm
    {
        public BrowserForm()
        {
            InitializeComponent();
            InitializeMaterialSkinManager();

            queryConstructorPage.DataCollected += cubeView.LoadData;
            queryConstructorPage.DataCollected
                += methodsPage.fullnessMapComponent.LoadData;
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
