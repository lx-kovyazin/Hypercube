using Hypercube.Client;
using Hypercube.Client.Model;
using Hypercube.Client.Extensions;

using Hypercube.Properties;
//using Microsoft.AnalysisServices.AdomdClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics.CodeAnalysis;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Hypercube
{
    public partial class Browser 
        : MaterialForm
    {
        private readonly Client.Client client;
        private readonly TreeNode moTreeClickedNode;
        private readonly TreeNode moTreFunctionNode;
        private AdomdTextEditor commandTextEditor;

        public Browser()
        {
            InitializeComponent();
            InitializeTextEditor();
            InitializeMaterialSkinManager();

            client = new Client.Client();
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
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
        }

        [Obsolete]
        private void InitializeTextEditor()
        {
            commandTextEditor = new AdomdTextEditor
            {
                Dock = DockStyle.Fill,
                AllowDrop = true
            };
            tabControl1.TabPages[0].Controls.Add(commandTextEditor);
            commandTextEditor.ContextMenuStrip = contextMenuStrip1;
        }

        private void LoadCatalogList()
            => comboBoxCatalogList.Items.AddRange(client.MetaInfo.Catalogs.ToArray());
        private void LoadCubes()
            => comboBoxCubeList.Items.AddRange(client.MetaInfo.Cubes.ToArray());

        [Obsolete]
        private void LoadFunctions()
        {
            //treFunctions.Connection = moConn;
            throw new NotImplementedException();
        }

        [Obsolete]
        private void CboCatalogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sCatalogName = comboBoxCatalogList.Text;
            client.Connection.ChangeDatabase(sCatalogName);
            LoadCubes();
        }

        [Obsolete]
        private void Default_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        [Obsolete]
        private void cboCubes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cube oCube = comboBoxCubeList.SelectedItem as Cube;
            //adomdDimTree1.Cube = oCube;
            //commandTextEditor.Text = MDXHelpers.CreateDefaultQuery(oCube);
        }

        [Obsolete]
        private void CommandButton_Click(object sender, EventArgs e)
        {
            //Command dlgCommand = new Command
            //{
            //    Connection = moConn,
            //    Cube = comboBoxCubeList.SelectedItem as CubeDef
            //};

            //dlgCommand.Show();
        }

        private void btnExecuteCellSet_Click(object sender, EventArgs e)
        {
            //client.CreateCommand(new MdxCommandProvider(new MDXBuilder)).ExecuteCellSet();
        }

        private void BtnExecuteReader_Click(object sender, EventArgs e)
        {
            //client.CreateCommand(new MdxCommandProvider()).ExecuteReader();
        }

        private void BtnExecuteDataSet_Click(object sender, EventArgs e)
        {
            //client.CreateCommand(new MdxCommandProvider()).ExecuteCellSet;
            //string sMDX = GetCommand();

            //try
            //{
            //    AdomdCommand oCmd = new AdomdCommand(sMDX, moConn);

            //    AdomdDataAdapter da = new AdomdDataAdapter(oCmd);

            //    DataTable dt = new DataTable();

            //    da.Fill(dt);

            //    grdResults.LoadData(dt);
            //    grdResults.AutoSize();
            //}
            //catch (AdomdException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //catch (InvalidOperationException exo)
            //{
            //    MessageBox.Show(exo.Message);
            //}
        }


        private void adomdDimTree1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            TreeNode oDragNode = moTreeClickedNode;

            if (oDragNode is null)
            {
                oDragNode = adomdDimTree1.SelectedNode;
            }

            string sData = GetNodeText(oDragNode);

            if (sData != string.Empty)
            {
                DoDragDrop(sData, DragDropEffects.Move);
            }

            //grdResults.Select();
            commandTextEditor.Select();
        }


        private string GetNodeText(TreeNode node)
        {
            string sData = string.Empty;
            //if (node != null)
            //{
            //    sData = node.Text;
            //    object oTag = node.Tag;

            //    if (oTag != null)
            //    {
            //        if (oTag is Level)
            //        {
            //            sData = (oTag as Level).UniqueName;
            //        }
            //        else if (oTag is Member)
            //        {
            //            sData = (oTag as Member).UniqueName;
            //        }
            //        else if (oTag is Dimension)
            //        {
            //            sData = (oTag as Dimension).UniqueName;
            //        }
            //        else if (oTag is Hierarchy)
            //        {
            //            sData = (oTag as Hierarchy).UniqueName;
            //        }
            //        else if (oTag is Measure)
            //        {
            //            sData = (oTag as Measure).UniqueName;
            //        }
            //        else if (oTag is CubeDef)
            //        {
            //            sData = "[" + (oTag as CubeDef).Name + "]";
            //        }
            //        else if (oTag is Kpi)
            //        {
            //            if (node.Nodes.Count > 0)
            //            {
            //                sData = (oTag as Kpi).Name;
            //            }
            //            else
            //            {
            //                oTag = node.Parent.Tag;
            //                if (sData == "Status")
            //                {
            //                    sData = "KpiStatus(\"" + (oTag as Kpi).Name + "\")";
            //                }
            //                else if (sData == "Value")
            //                {
            //                    sData = "KpiValue(\"" + (oTag as Kpi).Name + "\")";
            //                }
            //                else if (sData == "Goal")
            //                {
            //                    sData = "KpiGoal(\"" + (oTag as Kpi).Name + "\")";
            //                }


            //            }

            //        }
            //        else if (oTag is NamedSet)
            //        {
            //            sData = "[" + (oTag as NamedSet).Name + "]";
            //        }
            //    }

            //}
            return sData;
        }

        [Obsolete]
        private void Connect_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.StartingLoc = Location;
            Settings.Default.StartingSize = Size;
            //Settings.Default.Servers = textBoxServerName.AutoCompleteCustomSource;
            Settings.Default.Save();
        }

        #region Tool strip handlers.

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandTextEditor.Undo();
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandTextEditor.Redo();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandTextEditor.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandTextEditor.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandTextEditor.Paste();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandTextEditor.SelectAll();
        }

        private void SchemaInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var oDlg = new frmSchemaInfo(client.Connection))
            {
                oDlg.ShowDialog();
            }
        }

        private void windowSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Size.ToString());
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adomdDimTree1.SelectedNode != null)
                new PropertiesDlg(adomdDimTree1.SelectedNode.Tag).ShowDialog();
        }

        private void copyCaptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adomdDimTree1.SelectedNode != null)
            {
                Clipboard.SetText(adomdDimTree1.SelectedNode.Text);
            }
        }

        private void copyNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adomdDimTree1.SelectedNode != null)
            {
                Clipboard.SetText(adomdDimTree1.SelectedNode.Text);
            }
        }

        private void propertiesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var propertiesDlg = new PropertiesDlg(commandTextEditor.BaseControl))
            {
                propertiesDlg.ShowDialog();
            }
        }

        #endregion

        private void TreFunctions_ItemDrag(object sender, ItemDragEventArgs e)
        {

            var oDragNode = moTreFunctionNode;

            if (e.Item is TreeNode)
            {
                oDragNode = e.Item as TreeNode;
            }

            if (oDragNode == null)
            {
                oDragNode = treFunctions.SelectedNode;
            }

            if (oDragNode.Parent == null)
            {
                return;
            }

            if (oDragNode != null)
            {
                string sData = oDragNode.Text;
                object oTag = oDragNode.Tag;

                if (oTag != null)
                {
                    if (oTag is FunctionData)
                    {
                        sData = (oTag as FunctionData).DragValue;
                        DoDragDrop(sData, DragDropEffects.Copy);
                    }
                }
            }
        }

        private void treFunctions_MouseMove(object sender, MouseEventArgs e)
        {
            TreeNode oNode = treFunctions.GetNodeAt(e.X, e.Y);
            if (oNode != null)
            {
                object oTag = oNode.Tag;
                if ((oTag != null) && (oTag is FunctionData))
                {
                    FunctionData oData = oTag as FunctionData;
                    string sText = oData.DragValue;
                    if ((oData.Description != null) && (oData.Description.Length > 0))
                    {
                        sText += "\n" + oData.Description;
                    }

                    if (toolTip1.GetToolTip(treFunctions) != sText)
                    {
                        toolTip1.SetToolTip(treFunctions, sText);
                    }
                }
            }
            else
            {
                toolTip1.SetToolTip(treFunctions, "");
            }
        }

        private void adomdDimTree1_MouseMove(object sender, MouseEventArgs e)
        {
            //TreeNode oNode = adomdDimTree1.GetNodeAt(e.X, e.Y);
            //if (oNode != null)
            //{
            //    object oTag = oNode.Tag;
            //    string sText;

            //    if (oTag is Member)
            //    {
            //        Member oMember = oTag as Member;
            //        sText = oMember.Caption + "\n" + oMember.UniqueName;
            //        if (oMember.Description.Length > 0)
            //        {
            //            sText += "\n" + oMember.Description;
            //        }

            //        if (oMember.Properties.Count > 0)
            //        {
            //            string sProps = MemberPropertiesString(oMember);
            //            sText += "\n" + sProps;
            //        }
            //    }
            //    else if (oTag is Measure)
            //    {
            //        Measure oMeasure = oTag as Measure;
            //        sText = oMeasure.Caption + "\n" + oMeasure.UniqueName;
            //        if (oMeasure.Description.Length > 0)
            //        {
            //            sText += "\n" + oMeasure.Description;
            //        }
            //    }
            //    else if (oTag is Dimension)
            //    {
            //        Dimension oDim = oTag as Dimension;
            //        sText = oDim.Caption + "\n" + oDim.UniqueName;
            //    }
            //    else if (oTag is Hierarchy)
            //    {
            //        Hierarchy oHier = oTag as Hierarchy;
            //        sText = oHier.Caption + "\n" + oHier.UniqueName;
            //    }
            //    else if (oTag is Level)
            //    {
            //        Level oLevel = oTag as Level;
            //        sText = oLevel.Caption + "\n" + oLevel.UniqueName;
            //    }
            //    else if (oTag is Kpi)
            //    {
            //        Kpi oKpi = oTag as Kpi;
            //        sText = oKpi.Caption + "\n" + oKpi.Description;
            //    }
            //    else
            //    {
            //        toolTip1.SetToolTip(adomdDimTree1, "");
            //        return;
            //    }

            //    if (toolTip1.GetToolTip(adomdDimTree1) != sText)
            //    {
            //        toolTip1.SetToolTip(adomdDimTree1, sText);
            //    }
            //}
            //else
            //{
            //    toolTip1.SetToolTip(adomdDimTree1, "");
            //}
        }

        [Obsolete]
        private string MemberPropertiesString(/*Member aMember*/)
        {
            string sText = "";

            //foreach (Property oProp in aMember.Properties)
            //{
            //    if (sText.Length > 0)
            //    {
            //        sText += "\n" + oProp.Name + "=" + oProp.Value;
            //    }
            //    else
            //    {
            //        sText = oProp.Name + "=" + oProp.Value;
            //    }
            //}

            return sText;
        }

        private void menuDimTree_Opening(object sender, CancelEventArgs e)
        {
            copyCaptionToolStripMenuItem.Enabled = false;
            copyNameToolStripMenuItem.Enabled = false;
            if (moTreeClickedNode != null)
            {
                copyCaptionToolStripMenuItem.Enabled = true;
            }
            propertiesToolStripMenuItem.Enabled = false;
            if ((adomdDimTree1.SelectedNode != null) && (adomdDimTree1.SelectedNode.Tag != null))
            {
                propertiesToolStripMenuItem.Enabled = true;
            }
        }

        private bool mbActivated;
        private void Connect_Activated(object sender, EventArgs e)
        {
            if (mbActivated)
            {
                return;
            }

            //if (Settings.Default.StartingLoc != null)
            //    this.Location = (System.Drawing.Point)Settings.Default.StartingLoc;
            //if (Settings.Default.StartingSize != null)
            //    this.Size = (System.Drawing.Size)Settings.Default.StartingSize;

            //if (Settings.Default.Servers != null)
            //{
            //    textBoxServerName.AutoCompleteCustomSource = Settings.Default.Servers;
            //}
            //else
            //{
            //    textBoxServerName.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            //}

            Font = Settings.Default.Font;
            Settings.Default.PropertyChanged += new PropertyChangedEventHandler(Default_PropertyChanged);
            mbActivated = true;
        }

        private void adomdDimTree1_MouseClick(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && (adomdDimTree1.SelectedNode != null))
            {
                menuDimTree.Show();
            }
        }

        [Obsolete]
        private void btnReconnect_Click(object sender, EventArgs e)
        {
            if ((comboBoxCubeList.SelectedItem != null) && (comboBoxCatalogList.SelectedItem != null))
            {
                if (commandTextEditor.Text == "")
                {
                    string sCatalogName = comboBoxCatalogList.Text;
                    string sCubeName = comboBoxCubeList.Text;

                    client.Connection.ChangeDatabase(sCatalogName);
                    LoadCubes();

                    comboBoxCubeList.Text = sCubeName;

                    //Cube oCube = comboBoxCubeList.SelectedItem as Cube;
                    //adomdDimTree1.Cube = oCube;
                }
            }
        }

        private void formatMDXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandTextEditor.Text = MDXHelpers.FormatMDX(commandTextEditor.Text);
        }

        private void cellPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iRow = grdResults.Selection.ActivePosition.Row;
            int iCol = grdResults.Selection.ActivePosition.Column;

            grdResults.CheckCellData(iRow, iCol);
        }

        [Obsolete]
        private void adomdDimTree1_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.Control) && (e.KeyCode == Keys.C))
                Clipboard.SetText(GetNodeText(adomdDimTree1.SelectedNode));
        }

        [Obsolete]
        private void adomdDimTree1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                adomdDimTree1.SelectedNode = adomdDimTree1.GetNodeAt(new Point(e.X, e.Y));
        }
    }
}