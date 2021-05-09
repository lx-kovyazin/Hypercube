namespace Hypercube.Client.Data.Extractor
{
    public interface IDataExtractor<in T, out U>
        where T : class
        where U : ExtractedData
    {
        U ReadData(T dataMedium);
    }
}
