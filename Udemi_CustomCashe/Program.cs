IDataDownloader dataDownloader = new SlowDataDownloader();
var cashDictionary = new CacheDict<object>();

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
    string DownloadData(string resourceId, CacheDict<object> casheDict);
}

public class SlowDataDownloader : IDataDownloader
{
    public string DownloadData(string resourceId, CacheDict<object> casheDict)
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

public class CacheDict <T>
{
    public Dictionary<string, T> Data { get; set; }

    public CacheDict()
    {
        Data = new Dictionary<string, T>();
    }
    public bool IsInside (string id)
    {
        return Data.ContainsKey(id);
    }

    public T GetById (string id)
    {
        return Data[id];
    }

    public void AddToDict (string id, T value)
    {
        Data[id] = value;
    }
}