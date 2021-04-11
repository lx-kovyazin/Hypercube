using Hypercube.Client;
using Hypercube.Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.AnalysisServices.AdomdClient;

using HypercubeClient = Hypercube.Client.Client;
using System.Diagnostics;

namespace Hypercube.Control
{
    public partial class CubeTreeComponent
        : UserControl
    {
        private Cube cube;

        public CubeTreeComponent()
        {
            InitializeComponent();

            HypercubeClient.Instance.ConnectionChanged += () =>
            {
                cube = HypercubeClient.Instance.MetaInfo.CurrentCube;
                if (cube != null)
                    FillTree();
            };
        }

        private static void AddHierarchy(CubeTreeNode dimensionNode, Hierarchy hierarchy)
        {
            var hierarchyNode = new CubeTreeNode(hierarchy);
            dimensionNode.Nodes.Add(hierarchyNode);
            if (hierarchy is UserHierarchy userHierarchy)
                userHierarchy.Levels.ForEach(level => hierarchyNode.Nodes.Add(new CubeTreeNode(level)));
        }

        private static void AddDimension(CubeTreeNode cubeNode, Dimension dimension)
        {
            var dimensionNode = new CubeTreeNode(dimension);
            cubeNode.Nodes.Add(dimensionNode);
            dimension.Hierarchies.ForEach(hierarchy => AddHierarchy(dimensionNode, hierarchy));

        }

        private static void AddMeasure(CubeTreeNode cubeNode, Measure measure)
        {
            var measureNode = new CubeTreeNode(measure);
            cubeNode.Nodes.Add(measureNode);
        }

        private void FillTree()
        {
            cubeTreeView.Nodes.Clear();

            var cubeNode = new CubeTreeNode(cube);
            cubeTreeView.Nodes.Add(cubeNode);
            cube.Dimensions.ForEach(dimension => AddDimension(cubeNode, dimension));
            cube.Measures.ForEach(measure => AddMeasure(cubeNode, measure));

            cubeNode.Expand();
        }

        private void CubeTreeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Debug.Print($"[Drag]: {(e.Item as CubeTreeNode).Tag}");
                DoDragDrop((e.Item as CubeTreeNode).Tag, DragDropEffects.Link);
            }
        }
    }
}
