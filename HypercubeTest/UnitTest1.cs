using Hypercube.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Hypercube.Test
{
    [TestClass]
    public class HypercubeClientTest
    {
        ConnectionString connectionString;

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
        public void FilterStringListTest()
        {
            var capturedString = "ab";
            var stringList = new List<string> { "abc", "abcd", "qwe" };
            var filteredStringList = stringList.Where(str => str.StartsWith(capturedString)).ToList();
            var firstString = filteredStringList.First();
        }
    }
}
