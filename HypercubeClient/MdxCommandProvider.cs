using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MDXBuilderLibrary.mdx;

namespace Hypercube.Client
{
    public class MdxCommandProvider
        : ICommandProvider
    {
        private readonly MDXBuilder mdxBuilder;

        public MdxCommandProvider() => mdxBuilder = new MDXBuilder();

        public MDXBuilder Builder => mdxBuilder;

        #region ICommandProvider implementation.
        public string Name => nameof(MdxCommandProvider);
        public string Command => mdxBuilder.Build();
        #endregion
    }
}
