using Udemi_VideoGames_Exceptions.Model;
using static System.Net.Mime.MediaTypeNames;

const string FileName = ".\\games_info.json";


var file = new JsonFile (FileName); 

var games = file.ReadAll();

games.Print();

Console.ReadLine();
