using Newtonsoft.Json;

namespace Udemi_VideoGames_Exceptions.Model
{
    public class JsonFile
    {
        private string _fileName;
        
        public JsonFile (string fileName)
        {
            _fileName = fileName;
        }

        public VideoGameStorage ReadAll()
        {
            string jsonString = File.ReadAllText(_fileName);
            var gameList = JsonConvert.DeserializeObject<List<VideoGame>>(jsonString);
            return new VideoGameStorage(gameList);
        }

        public bool Exist()
        {
            return File.Exists(_fileName);
        }

    }
}
