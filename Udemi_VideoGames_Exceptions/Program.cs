using Udemi_VideoGames_Exceptions.Model;
using Udemi_VideoGames_Exceptions.UserInterface;

const string GameFileName = "games_info.json";
const string LogFileName = "logs.txt";

//var file = new JsonFile (FileName); 
var logFile = new LogFile(LogFileName);
var file = UserInput.TryGetFileFormUser();

var games = file.ReadAll(logFile);

games.Print();

Console.ReadLine();
