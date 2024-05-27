using System.IO;
using Udemi_CookieCookbook.Model;
using Udemi_CookieCookbook.WorkWithFiles;

//print all saved recipies
const string FileName = "recipes";
const FileFormat FileFormat = FileFormat.Json; //could be txt or json

var ingStorige = new IngridientStorage();

string fileName = FileFormat == FileFormat.Txt ? $"{FileName}.txt" : $"{FileName}.json";
IOperatingFile file = FileFormat == FileFormat.Txt ? new TextFile(fileName) : new JsonFile(fileName);

if (File.Exists(fileName))
{
    var recipeStorage = file.ReadAll(fileName, ingStorige);
    recipeStorage.Print();
}

//print list of available ingridients
ingStorige.Print();

//input new recipe
Console.WriteLine("Create a new cookie recipe!");
var recipe = User.InputListIngridients(ingStorige);

if (recipe == null)
{
    Console.WriteLine("No ingredients have been selected. Recipe will not be saved");
}
else
{
    //storing recipe
    file.Append(recipe);
    Console.WriteLine("Recipe added");
    recipe.Print();
}

Console.WriteLine("Press any key to exit");
Console.ReadLine();

