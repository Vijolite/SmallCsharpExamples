using Udemi_CookieCookbook.WorkWithFiles;

namespace Udemi_CookieCookbook.Model
{
    public class CookiesRecipesApp
    {
        private const string FileName = "recipes";
        private const FileFormat CurrentFileFormat = FileFormat.Json; //could be txt or json

        IngridientStorage _ingridientStorige;
        IOperatingFile _file;
        string _fileName;

        public CookiesRecipesApp()
        {
            _fileName = CurrentFileFormat == FileFormat.Txt ? $"{FileName}.txt" : $"{FileName}.json";
            _file = CurrentFileFormat == FileFormat.Txt ? new TextFile(_fileName) : new JsonFile(_fileName);
            _ingridientStorige = new IngridientStorage();
        }

        public void Run()
        {
            PrintAllSavedRecipes();

            InputNewRecipe();

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        public void PrintAllSavedRecipes()
        {
            if (File.Exists(_fileName))
            {
                var recipeStorage = _file.ReadAll(_fileName, _ingridientStorige);
                recipeStorage.Print();
            }
        }

        public void InputNewRecipe()
        {
            _ingridientStorige.Print();
            Console.WriteLine("Create a new cookie recipe!");
            var recipe = User.InputListIngridients(_ingridientStorige);

            if (recipe == null)
            {
                Console.WriteLine("No ingredients have been selected. Recipe will not be saved");
            }
            else
            {
                //storing recipe
                _file.Append(recipe);
                Console.WriteLine("Recipe added");
                recipe.Print();
            }
        }
        
    }
}
