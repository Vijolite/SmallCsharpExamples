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

        public VideoGameStorage ReadAll(LogFile logFile)
        {
            string jsonString = File.ReadAllText(_fileName);
            try
            {
                var gameList = JsonConvert.DeserializeObject<List<VideoGame>>(jsonString);
                return new VideoGameStorage(gameList);
            }
            catch (JsonSerializationException ex)
            {
                var logInfoItem = new LogInfoItem("File does not contain a valid Json", ex.Message);
                Console.WriteLine(logInfoItem.ToString());
                logFile.Append(logInfoItem.ToString());
                //throw;
            }
            catch (JsonReaderException ex)
            {
                var logInfoItem = new LogInfoItem("File does not contain a valid Json", ex.Message);
                Console.WriteLine(logInfoItem.ToString());
                logFile.Append(logInfoItem.ToString());
                //throw;
            }
            return null;
            
        }

        public bool Exist()
        {
            return File.Exists(_fileName);
        }

    }
}
