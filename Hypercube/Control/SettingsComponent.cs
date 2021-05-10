using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Hypercube.Client;

namespace Hypercube.Control
{
    public partial class SettingsComponent : UserControl
    {
        public SettingsComponent()
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
