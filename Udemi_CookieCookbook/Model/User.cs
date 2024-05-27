using System;

namespace Udemi_CookieCookbook.Model
{
    public static class User
    {
        public static string Input()
        {
            string x = Console.ReadLine();
            return x;
        }

        public static Recipe? InputListIngridients(IngridientStorage storage)
        {
            
            bool correctInput = true;
            var recipe = new Recipe();

            do
            {
                Console.WriteLine("Input Id of ingriedient you want to add or anything else to finish");
                string inputStr = Console.ReadLine();
                int inputInt = 0;
                if (int.TryParse(inputStr, out inputInt))
                {
                    var ingriedient = storage.FindIngridient(inputInt);
                    recipe.AddIngridient(ingriedient);
                }
                else
                {
                    correctInput = false;
                }
            } while (correctInput);
            return recipe.Ingridients.Count>0?recipe:null;
        }
    }
}