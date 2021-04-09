using MDXBuilderLibrary.mdx.interfaces;

namespace MDXBuilderLibrary.mdx.axisitems.Functions
{
    public abstract class SuffixFunction<T>
        : IMDXAxisItem
        where T : class
    {
        protected readonly IMDXAxisItem item;

        protected SuffixFunction(IMDXAxisItem item)
            => this.item = item;

        public virtual string Build()
            => $"{item.Build()}.{GetType().Name}";

        public override string ToString() => nameof(T);
    }
}
