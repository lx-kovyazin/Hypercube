﻿using Hypercube.Client;
using Hypercube.Control.Filter;
using MdxBuilder;
using MdxBuilder.Builder;
using MdxBuilder.Entity;
using MdxBuilder.Entity.Function.Set;
using MdxBuilder.Entity.Operator.Unary;
using MdxBuilder.Utils;
using Microsoft.AnalysisServices.AdomdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crossjoin = MdxBuilder.Entity.Operator.Set.Crossjoin;
using HypercubeClient = Hypercube.Client.Client;
using Set = MdxBuilder.Entity.Set;

namespace Hypercube.Control
{
    public partial class QueryConstructor : UserControl
    {
        public event Action<CellSet> DataCollected;

        public QueryConstructor()
            => InitializeComponent();

        private static UniqueEntity TransformFilterItem(FilterListViewItem item)
        {
            var filterListSubItems = item.SubItems.Cast<FilterListViewSubItem>().ToArray();
            var hsi = filterListSubItems[0] as FilterListViewHierarchySubItem;
            var osi = filterListSubItems[1] as FilterListViewOperatorSubItem;
            var vsi = filterListSubItems[2] as FilterListViewValueSubItem;
            Debug.Print($"On {hsi.Hierarchy} perform {osi.Current} by {vsi.Text}");

            var msb = new SetBuilder();
            vsi.SelectedMembers.ForEach(
                m => msb.Add(tb => tb.Add(new UniqueEntity(m.UniqueName)))
            );

            UniqueEntity op;
            switch (osi.Current)
            {
                case FilterListViewOperatorSubItem.Operator.Equals:
                    op = new UniqueEntity(msb.Build().Body);
                    break;

                case FilterListViewOperatorSubItem.Operator.NotEquals:
                    op = Negative.Do(new UniqueEntity(msb.Build().Body).AsOp());
                    break;

                default:
                    throw new Exception($"Unexpected filter operator: {osi.Current}.");
            }

            return op;
        }

        private SubCube CreateSubcubeRecursively(
            IEnumerator<FilterListViewItem> items
            )
        {
            var scb = new SubCubeBuilder();
            if (!items.MoveNext())
                return scb.Set(new Cube(HypercubeClient.Instance.MetaInfo.CurrentCube.UniqueName)).Build();

            var op = TransformFilterItem(items.Current);
            return scb.Set(qb => qb
                .Select(seb => seb
                    .Add(aab => aab
                        .SetDimension(AliasedAxis.Alias.Columns)
                        .Set(sb => sb.Add(tb => tb.Add(op)))))
                .From(feb => feb.Set(CreateSubcubeRecursively(items)))
                ).Build();
        }


        private MdxCommandProvider PrepareCommand()
        {
            var dimensionMetaListViewItems = constructorComponent.dimensionMetaListView.fixedListView.Items.Cast<FixedMetaListViewItem>();
            var measureMetaListViewItems = constructorComponent.measureMetaListView.fixedListView.Items.Cast<FixedMetaListViewItem>();
            var cube = new Cube(HypercubeClient.Instance.MetaInfo.CurrentCube.UniqueName);

            List<UniqueEntity> listConverter
                (IEnumerable<FixedMetaListViewItem> list)
                    => list.Select(item => new UniqueEntity(item.Model.UniqueName)).ToList();

            var measureSet = new SetBuilder();
            listConverter(measureMetaListViewItems)
                .ForEach(it => measureSet.Add(tb => tb.Add(it)));

            var dimensions = listConverter(dimensionMetaListViewItems)
                .Select(item => AllMembers.Do(item)).AsOp();

            var filterListItems
                = constructorComponent.filterComponent
                                      .filterListView
                                      .Items
                                      .Cast<FilterListViewItem>();

            var sc = CreateSubcubeRecursively(filterListItems.GetEnumerator());

            var query
                = Mdx.Create()
                     .Select(seb => seb
                         .Add(aabCols => aabCols
                             .SetDimension(AliasedAxis.Alias.Columns)
                             .Set(measureSet.Build())
                         )
                         .Add(aabRows => aabRows
                             .SetDimension(AliasedAxis.Alias.Rows)
                             .Set(sb => sb.Add(tb => tb.Add(
                                 Crossjoin.Do(dimensions)
                        ))))
                     )
                     .From(feb => feb.Set(sc))
                     .Build()
                     ;

            return new MdxCommandProvider(query);
        }

        private void ConstructorTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (
                e.TabPage.Equals(queryTabPage)
                &&   ( constructorComponent.dimensionMetaListView.fixedListView.Items.Count > 0
                    && constructorComponent.measureMetaListView.fixedListView.Items.Count > 0
               ))
                commandComponent.scintilla.Text = PrepareCommand().Command;
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            DataCollected.Invoke(HypercubeClient.Instance.CreateCommand(PrepareCommand()).ExecuteCellSet());
        }
    }
}
