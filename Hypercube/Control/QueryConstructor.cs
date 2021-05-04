using Hypercube.Client;
using MdxBuilder;
using MdxBuilder.Builder;
using MdxBuilder.Entity;
using MdxBuilder.Entity.Function.Set;
using MdxBuilder.Entity.Operator.Set;
using MdxBuilder.Utils;
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
using Crossjoin = MdxBuilder.Entity.Operator.Set.Crossjoin;
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
                     .From(feb => feb.Set(sc => sc.Set(cube)))
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
