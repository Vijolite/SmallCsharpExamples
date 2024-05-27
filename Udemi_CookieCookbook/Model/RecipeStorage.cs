using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
