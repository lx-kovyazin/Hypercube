using MdxBuilder;

namespace Hypercube.Client
{
    public class MdxCommandProvider
        : ICommandProvider
    {
        private readonly string command;

        public MdxCommandProvider(Mdx.Query query)
            : this(query.Body)
        { }

        public MdxCommandProvider(string mdxQuery)
            => command = mdxQuery;

        public static Mdx.QueryBuilder Builder => Mdx.Create();

        #region ICommandProvider implementation.
        public string Name => nameof(MdxCommandProvider);
        public string Command => command;
        #endregion
    }
}
