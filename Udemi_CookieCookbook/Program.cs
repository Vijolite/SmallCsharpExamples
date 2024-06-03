using Udemi_CookieCookbook.Model;
using Udemi_CookieCookbook.WorkWithFiles;

const string FileName = "recipes";
const FileFormat CurrentFileFormat = FileFormat.Json; //could be txt or json

var ingridientStorage = new IngridientStorage();

string fileName = CurrentFileFormat == FileFormat.Txt ? $"{FileName}.txt" : $"{FileName}.json";

var cookiesRecipesApp = new CookiesRecipesApp(ingridientStorage, CurrentFileFormat == FileFormat.Txt ? new TextFile(fileName) : new JsonFile(fileName));
cookiesRecipesApp.Run();

