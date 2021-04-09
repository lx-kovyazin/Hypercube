// TODO: Implement a logger.

namespace Hypercube.Client
{
    public class ConnectionString
    {
        const string PROVIDER_MSOLAP = "MSOLAP";
        const string SOURCE_ALIAS = "Data source";

        public string Catalog { get; set; }
        public string Cube { get; set; }

        public string Provider { get { return PROVIDER_MSOLAP; } }
        public string Source { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ConnectionString @string
                && Catalog == @string.Catalog
                && Cube == @string.Cube
                && Provider == @string.Provider
                && Source == @string.Source
                ;
        }

        public override string ToString()
        {
            return string.Join(";",
                $"{nameof(Provider)}={Provider}",
                $"{SOURCE_ALIAS}={Source}",
                $"{nameof(Catalog)}={Catalog}",
                $"{nameof(Cube)}={Cube}"
            );
        }
    }
}
