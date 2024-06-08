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
            try
            {
                var gameList = JsonConvert.DeserializeObject<List<VideoGame>>(jsonString);
                return new VideoGameStorage(gameList);
            }
            catch (JsonSerializationException ex)
            {
                Console.WriteLine("File does not contain a valid Json: " + ex.Message);
                throw;
            }
            catch (JsonReaderException ex)
            {
                Console.WriteLine("File does not contain a valid Json: " + ex.Message);
                throw;
            }
            
        }

        public bool Exist()
        {
            return File.Exists(_fileName);
        }

    }
}
