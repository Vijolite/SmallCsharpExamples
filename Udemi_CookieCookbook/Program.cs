using Udemi_CookieCookbook.Model;
using Udemi_CookieCookbook.WorkWithFiles;

const string FileName = "recipes";
const FileFormat CurrentFileFormat = FileFormat.Json; //could be txt or json

var ingridientStorage = new IngridientStorage();

string fileName = $"{FileName}.{CurrentFileFormat.AsFileExtension()}";
var file = CurrentFileFormat.CreateNewFile(fileName);

var cookiesRecipesApp = new CookiesRecipesApp(ingridientStorage, file);
cookiesRecipesApp.Run();

