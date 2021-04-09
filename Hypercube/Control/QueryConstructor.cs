﻿using Hypercube.Client;
using MDXBuilderLibrary.mdx;
using MDXBuilderLibrary.mdx.axisitems;
using MDXBuilderLibrary.mdx.axisitems.Functions;
using Microsoft.AnalysisServices.AdomdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HypercubeClient = Hypercube.Client.Client;

namespace Hypercube.Control
{
    public partial class QueryConstructor : UserControl
    {
        public event Action<CellSet> DataCollected;

        public QueryConstructor()
        {
            InitializeComponent();
        }

        private MdxCommandProvider PrepareCommand()
        {
            var mdxProvider = new MdxCommandProvider();

            mdxProvider.Builder.CubeName = HypercubeClient.Instance.MetaInfo.CurrentCube.UniqueName;

            var dimensionMetaListViewItems = constructorComponent.dimensionMetaListView.fixedListView.Items.Cast<FixedMetaListViewItem>();
            var measureMetaListViewItems = constructorComponent.measureMetaListView.fixedListView.Items.Cast<FixedMetaListViewItem>();

            //Column Axis
            var columnAxis = new MDXAxis(MDXAxis.COLUMN_AXIS);
            var columnSetList = new SetAxisItem(null);
            foreach (var item in measureMetaListViewItems)
                columnSetList.AddAxisItem(new MemberAxisItem(item.Model.UniqueName));
            columnAxis.AxisItem = new NonEmpty(columnSetList);

            //Row Axis
            var rowAxis = new MDXAxis(MDXAxis.ROW_AXIS);
            var rowCrossJoin = new CrossJoin(null);
            foreach (var item in dimensionMetaListViewItems)
                rowCrossJoin.AddCrossJointTo(new Members(new MemberAxisItem(item.Model.UniqueName)));
            rowAxis.AxisItem = new NonEmpty(rowCrossJoin);

            //Add Axis to Builder
            mdxProvider.Builder.AddAxis(columnAxis);
            mdxProvider.Builder.AddAxis(rowAxis);

            return mdxProvider;
        }

        private void ConstructorTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Equals(queryTabPage))
                commandComponent.scintilla.Text = PrepareCommand().Command;
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            DataCollected.Invoke(HypercubeClient.Instance.CreateCommand(PrepareCommand()).ExecuteCellSet());
        }
    }
}