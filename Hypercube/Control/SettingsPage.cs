using System.Windows.Forms;
using Hypercube.Client;
using MaterialSkin.Controls;

namespace Hypercube.Control
{
    public partial class SettingsPage
        : TabPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            executionMethodSwitch.CheckedChanged += (s, e) => {
                var @switch  = s as MaterialSwitch;
                if (@switch.Checked)
                {
                    Settings.ExecMethod = Command.ExecMethod.AdomdDataReader;
                    @switch.Text = nameof(Command.ExecMethod.AdomdDataReader);
                }
                else
                {
                    Settings.ExecMethod = Command.ExecMethod.CellSet;
                    @switch.Text = nameof(Command.ExecMethod.CellSet);
                }
            };
            executionMethodSwitch.Checked = true;
        }
    }
}
