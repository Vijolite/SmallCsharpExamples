
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemi_CookieCookbook.Model
{
    public class Recipe
    {
        public List<Ingridient> Ingridients { get; set; }

        public Recipe (List<Ingridient> ingridients)
        {
            Ingridients = ingridients;
        }

        public Recipe()
        {
            Ingridients = new List<Ingridient>();
        }

        public void Print()
        {
            foreach (var ingridient in Ingridients)
            {
                Console.WriteLine($"Ingridient: {ingridient.Name} To do: {ingridient.Instruction}");
            }
        }

        public void AddIngridient (Ingridient ingridient)
        {
            Ingridients.Add(ingridient);
        }
    }

}
