using System;

namespace Udemi_CookieCookbook.Model
{
    public class User
    {
        public string Input()
        {
            string x = Console.ReadLine();
            return x;
        }

        public void Exit()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        public Recipe? InputListIngridients(IIngridientStorage storage)
        {
            
            bool correctInput = true;
            var recipe = new Recipe();

            do
            {
                Console.WriteLine("Input Id of ingriedient you want to add or anything else to finish");
                string inputStr = Console.ReadLine();
                int inputInt;
                if (int.TryParse(inputStr, out inputInt))
                {
                    var ingriedient = storage.FindIngridient(inputInt);
                    if (ingriedient != null)
                        recipe.AddIngridient(ingriedient);
                    else
                        correctInput = false;
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