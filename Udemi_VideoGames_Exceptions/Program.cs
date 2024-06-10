using Udemi_VideoGames_Exceptions.Model;
using Udemi_VideoGames_Exceptions.UserInterface;

var file = UserInput.TryGetFileFormUser();
var videoApp = new VideoGamesInfoApp(file);
videoApp.Run();
