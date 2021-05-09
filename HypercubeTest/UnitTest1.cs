using Hypercube.Client;
using Hypercube.Client.Data.Extractor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Hypercube.Test
{
    [TestClass]
    public class HypercubeClientTest
    {
        private ConnectionString connectionString;

        [TestInitialize]
        public void InitializeHypercubeClientTest()
        {
            connectionString = new ConnectionString()
            {
                Source = "localhost",
                Catalog = "HypercubeAS"
            };
        }

        [TestMethod]
        public void ClientConnectionIsOpened()
        {
            var client = Client.Client.Instance;
            client.Connect(connectionString);
            Assert.IsTrue(client.Connection.State == System.Data.ConnectionState.Open);
        }

        [TestMethod]
        public void ClientConnectionIsClosed()
        {
            var client = Client.Client.Instance;
            client.Connect(connectionString);
            client.Disconnect();
            Assert.IsTrue(client.Connection.State == System.Data.ConnectionState.Closed);
        }

        [TestMethod]
        public void GetMetadataTest()
        {
            var client = Client.Client.Instance;
            client.Connect(connectionString);
            Debug.Print(client.MetaInfo.ToString());
        }

        [TestMethod]
        public void CellExtractorTest()
        {
            var client = Client.Client.Instance;
            client.Connect(connectionString);
            const string query = "SELECT {([Measures].[Total Cases]), ([Measures].[New Cases])} ON COLUMNS, {([Date].[Date].AllMembers * [Location].[Continent].AllMembers * [Location].[Location].AllMembers)} ON ROWS FROM [CovidCube]";
            CellSetDataExtractor.Do(client.CreateCommand(new MdxCommandProvider(query)).ExecuteCellSet());
        }
    }
}
