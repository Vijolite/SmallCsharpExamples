namespace Udemi_CookieCookbook.Model
{
    public class RecipeStorage
    {
        public List<Recipe> Recipes { get; set; } = new List<Recipe>();

        public RecipeStorage (List<Recipe> recipes)
        {
            Recipes = recipes;
        }

        public void Print()
        {
            if (Recipes.Count > 0)
            {
                Console.WriteLine("***** Existing recipes are: *****");
                int i = 1;
                foreach (var recipe in Recipes)
                {
                    Console.WriteLine($"----- {i} -----");
                    recipe.Print();
                    i++;
                }
            }
            Console.WriteLine($"---------------");
        }
    }
}
