IDataDownloader dataDownloader = new SlowDataDownloader();
var cashDictionary = new CacheDict<string, object>();

Console.WriteLine(dataDownloader.DownloadData("id1", cashDictionary));
Console.WriteLine(dataDownloader.DownloadData("id2", cashDictionary));
Console.WriteLine(dataDownloader.DownloadData("id3", cashDictionary));
Console.WriteLine(dataDownloader.DownloadData("id1", cashDictionary));
Console.WriteLine(dataDownloader.DownloadData("id3", cashDictionary));
Console.WriteLine(dataDownloader.DownloadData("id1", cashDictionary));
Console.WriteLine(dataDownloader.DownloadData("id2", cashDictionary));

Console.ReadKey();

public interface IDataDownloader
{
    string DownloadData(string resourceId, CacheDict<string, object> casheDict);
}

public class SlowDataDownloader : IDataDownloader
{
    public string DownloadData(string resourceId, CacheDict<string, object> casheDict)
    {
        var downloadedUnit = new object();
        if (!casheDict.IsInside(resourceId))
        {
            //let's imagine this method downloads real data,
            //and it does it slowly
            Thread.Sleep(1000);
            downloadedUnit = new CasheDataUnit<object>(new object());
            casheDict.AddToDict(resourceId, downloadedUnit);
            return $"Some data for {resourceId} from download";
        }
        else
        {
            downloadedUnit = casheDict.GetById(resourceId);
            return $"Some data for {resourceId} from cashe";
        }

        //return $"Some data for {resourceId}";
    }
}

public class CasheDataUnit <T>
{
    public T Value { get; set; }

    public CasheDataUnit (T value)
    {
        Value = value;
    }
    
}

public class CacheDict <TKey, TValue>
{
    public Dictionary<TKey, TValue> Data { get; set; }

    public CacheDict()
    {
        Data = new Dictionary<TKey, TValue>();
    }
    public bool IsInside (TKey id)
    {
        return Data.ContainsKey(id);
    }

    public TValue GetById (TKey id)
    {
        return Data[id];
    }

    public void AddToDict (TKey id, TValue value)
    {
        Data[id] = value;
    }
}