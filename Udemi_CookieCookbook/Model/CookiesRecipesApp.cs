using Udemi_CookieCookbook.WorkWithFiles;

namespace Udemi_CookieCookbook.Model
{
    public class CookiesRecipesApp
    {
        private IIngridientStorage _ingridientStorige;
        private IOperatingFile _file;
        User _user = new();

        public CookiesRecipesApp(IIngridientStorage ingriedientStorage, IOperatingFile file)
        {
            _ingridientStorige = ingriedientStorage;
            _file = file;
        }

        public void Run()
        {
            PrintAllSavedRecipes();

            InputNewRecipe();

            _user.Exit();
        }

        public void PrintAllSavedRecipes()
        {
            if (_file.Exist())
            {
                var recipeStorage = _file.ReadAll(_ingridientStorige);
                recipeStorage.Print();
            }
        }

        public void InputNewRecipe()
        {
            _ingridientStorige.Print();
            Console.WriteLine("Create a new cookie recipe!");
            var recipe = _user.InputListIngridients(_ingridientStorige);

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
