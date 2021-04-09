using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hypercube.Control
{
    public partial class AboutComponent
        : UserControl
    {
        public AboutComponent()
        {
            InitializeComponent();
            programDataLabel.Text = AssemblyTitle;
            versionDataLabel.Text = AssemblyVersion;
            developerDataLabel.Text = AssemblyProduct;
            organizationDataLabel.Text = AssemblyCompany;
            yearDataLabel.Text = AssemblyCopyright;
            descriptionTextBox.Text = AssemblyDescription;
        }

        private static T GetAttribute<T>() where T : Attribute => Assembly.GetExecutingAssembly().GetCustomAttribute<T>();

        private string AssemblyTitle => GetAttribute<AssemblyTitleAttribute>().Title;

        public string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public string AssemblyDescription => GetAttribute<AssemblyDescriptionAttribute>().Description;

        public string AssemblyProduct => GetAttribute<AssemblyProductAttribute>().Product;

        public string AssemblyCopyright => GetAttribute<AssemblyCopyrightAttribute>().Copyright;

        public string AssemblyCompany => GetAttribute<AssemblyCompanyAttribute>().Company;
    }
}
