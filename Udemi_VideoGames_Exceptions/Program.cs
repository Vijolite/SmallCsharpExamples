using Udemi_VideoGames_Exceptions.Model;
using Udemi_VideoGames_Exceptions.UserInterface;

const string FileName = "games_info.json";

//var file = new JsonFile (FileName); 
var file = UserInput.TryGetFileFormUser();

var games = file.ReadAll();

games.Print();

Console.ReadLine();
