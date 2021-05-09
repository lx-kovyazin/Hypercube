namespace Hypercube.Client.Data.Extractor
{
    public abstract class DataExtractor<TSelf, T, U>
        : IDataExtractor<T, U>
        where TSelf : DataExtractor<TSelf, T, U>, new()
        where T : class
        where U : ExtractedData
    {
        public const string NULL_PLACEHOLDER = "(null)";

        public abstract U ReadData(T dataMedium);

        public static U Do(T dataMedium)
            => new TSelf().ReadData(dataMedium);

    }
}
