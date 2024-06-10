namespace Udemi_VideoGames_Exceptions.Model
{
    public class VideoGamesInfoApp
    {
        const string GameFileName = "games_info.json";
        const string LogFileName = "logs.txt";

        Logger _logger { get; init; }
        JsonFile _dataFile { get; init; }

        public VideoGamesInfoApp(JsonFile dataFile)
        {
            _logger = new Logger(LogFileName);
            _dataFile = dataFile;
        }

        public void Run()
        {
            try
            {
                var games = _dataFile.ReadAll();
                games.Print();
            }
            catch (Exception ex)
            {
                _logger.Log(ex);
                Console.WriteLine("Sorry! The application has experienced an unexpected error" +
                    "and we will have to be closed");
            }

            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }   
    }
}
