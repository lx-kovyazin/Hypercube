using static Hypercube.Client.Command;

namespace Hypercube
{
    public static class Settings
    {
        public static ExecMethod ExecMethod
        {
            get;
            set;
        } = ExecMethod.AdomdDataReader;
    }
}
