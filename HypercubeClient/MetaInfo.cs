using Microsoft.AnalysisServices.AdomdClient;
using System.Collections.Generic;
using System.Linq;
using Hypercube.Client.Model;

namespace Hypercube.Client
{
    public class MetaInfo
    {
        private readonly Client client;
        private readonly List<string> catalogs;
        private readonly List<Cube> cubes;

        public MetaInfo(Client client)
        {
            this.client = client;
            catalogs = RetrieveCatalogs();
            cubes = RetrieveCubes();
        }

        private List<string> RetrieveCatalogs()
        {
            var catalogs = new List<string>();

            var ds = client.Connection.GetSchemaDataSet(AdomdSchemaGuid.Catalogs, new object[0]);
            foreach (System.Data.DataRow row in ds.Tables[0].Rows)
                catalogs.Add(row[0].ToString());

            return catalogs;
        }

        private List<Cube> RetrieveCubes()
            => client.Connection
                     .Cubes.OfType<CubeDef>()
                     .Where(cubeDef => cubeDef.Type == CubeType.Cube)
                     .Select(cubeDef => new Cube(cubeDef))
                     .ToList();

        public List<string> Catalogs => catalogs;
        public List<Cube> Cubes => cubes;
        public string CurrentCatalog => catalogs.Find(catalog => Equals(catalog, client.ConnectionString.Catalog));
        public Cube CurrentCube => cubes.Find(cube => Equals(cube.FriendlyName, client.ConnectionString.Cube));

        public override string ToString()
        {
            return "Meta:"
                 + $"\n {nameof(Catalogs)}[{Catalogs.Count}]"
                 + $"\n {nameof(Cubes)}[{Cubes.Count}]"
            ;
        }
    }
}
