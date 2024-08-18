//IDataDownloader DataDownloader = new SlowDataDownloader(); //to use old slow download way
//IDataDownloader dataDownloader = new CashingDataDownloader(new SlowDataDownloader()); //to use new download way with chashing
IDataDownloader dataDownloader = new PrintingDataDownloader(new CashingDataDownloader(new SlowDataDownloader()));

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
    public string DownloadData(string resourceId)
    {
        Thread.Sleep(1000);
        return $"Some data for {resourceId}";
    }
}

public class CashingDataDownloader : IDataDownloader
{
    private readonly IDataDownloader _dataDowloader = new SlowDataDownloader();
    private readonly CacheDict<string, string> _casheDict = new();

    public CashingDataDownloader (IDataDownloader dataDowloader)
    {
        _dataDowloader = dataDowloader;
    }

    public string DownloadData(string resourceId)
    {
        return _casheDict.GetById(resourceId, _dataDowloader.DownloadData);
    }
}

public class PrintingDataDownloader : IDataDownloader
{
    private readonly IDataDownloader _dataDowloader = new SlowDataDownloader();

    public PrintingDataDownloader(IDataDownloader dataDowloader)
    {
        _dataDowloader = dataDowloader;
    }

    public string DownloadData(string resourceId)
    {
        var data = _dataDowloader.DownloadData(resourceId);
        Console.WriteLine("data is dowloaded!");
        return data;
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