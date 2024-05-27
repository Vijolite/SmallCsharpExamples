using Udemi_CookieCookbook.Model;

//print all saved recipies
const string FileName = "recipes";
const FileFormat FileFormat = FileFormat.Txt; //could be txt or json


var ingStorige = new IngridientStorage();
ingStorige.Print();

Console.WriteLine("Create a new cookie recipe!");
var recipe = User.InputListIngridients(ingStorige);

if (recipe == null)
{
    Console.WriteLine("No ingredients have been selected. Recipe will not be saved");
}
else
{
    Console.WriteLine("Recipe added");
    recipe.Print();
}

//+storing recipe
Console.WriteLine("Press any key to exit");
Console.ReadLine();

