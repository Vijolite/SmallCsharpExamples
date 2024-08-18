IDataDownloader dataDownloader = new SlowDataDownloader();

Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));

Console.ReadKey();

public interface IDataDownloader
{
    string DownloadData(string resourceId);
}

public class SlowDataDownloader : IDataDownloader
{
    private readonly CacheDict<string, string> _casheDict = new();
    public string DownloadDataWithoutCashing(string resourceId)
    {
        Thread.Sleep(1000);
        return $"Some data for {resourceId}";
    }

    public string DownloadData(string resourceId)
    {
        return _casheDict.GetById(resourceId, DownloadDataWithoutCashing);
    }
}

public class CacheDict <TKey, TValue>
{
    public Dictionary<TKey, TValue> Data { get; set; }

    public CacheDict()
    {
        Data = new Dictionary<TKey, TValue>();
    }

    public TValue GetById (TKey id, Func<TKey, TValue> getForTheFirstTime)
    {
        if (!Data.ContainsKey(id))
        {
            Data[id] = getForTheFirstTime(id);
        }
        return Data[id];
    }
}