using Newtonsoft.Json;

namespace Udemi_VideoGames_Exceptions.Model
{
    public class JsonFile
    {
        public string FileName { get; init; }
        
        public JsonFile (string fileName)
        {
            FileName = fileName;
        }

        public VideoGameStorage ReadAll()
        {
            string jsonString = File.ReadAllText(FileName);
            try
            {
                var gameList = JsonConvert.DeserializeObject<List<VideoGame>>(jsonString);
                return new VideoGameStorage(gameList);
            }
            catch (JsonException ex)
            {
                throw new JsonException($"File {FileName} does not contain a valid Json ({ex.Message})");
            }
            
        }

        public bool Exist()
        {
            return File.Exists(FileName);
        }

    }
}
