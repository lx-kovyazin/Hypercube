using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Hypercube.Client;
using System.Diagnostics;

namespace Hypercube.Test
{
    [TestClass]
    public class HypercubeClientTest
    {
        [TestMethod]
        public void ClientConnectionIsOpened()
        {
            using (var client = new HypercubeClient())
            {
                client.Start();
                Assert.IsTrue(client.Connection.State == System.Data.ConnectionState.Open);
            }
        }

        [TestMethod]
        public void ClientConnectionIsClosed()
        {
            var client = new HypercubeClient();
            client.Start();
            client.Dispose();
            Assert.IsTrue(client.Connection.State == System.Data.ConnectionState.Closed);
        }

        [TestMethod]
        public void GetCubeCollectionTest()
        {
            using (var client = new HypercubeClient())
            {
                client.Start();

                if (client.Connection.Cubes is null || client.Connection.Cubes.Count == 0)
                    Assert.IsTrue(false);

                foreach (var cube in client.Connection.Cubes)
                {
                    if (cube.Type != Microsoft.AnalysisServices.AdomdClient.CubeType.Cube)
                        continue;

                    Debug.Print($"Cube: {cube}");
                    foreach (var dimension in cube.Dimensions)
                    {
                        if (dimension.DimensionType == Microsoft.AnalysisServices.AdomdClient.DimensionTypeEnum.Measure)
                            continue;

                        Debug.Print($"Dimension: {dimension}");
                    }

                    foreach (var measure in cube.Measures)
                    {
                        Debug.Print($"Measure: {measure}");
                    }
                }
                
                Assert.IsTrue(true);
            }
        }
    }
}
