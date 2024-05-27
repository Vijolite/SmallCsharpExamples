
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemi_CookieCookbook.Model
{
    public class IngridientStorage
    {
        public List<Ingridient> Ingridients { get; set; } = new List<Ingridient>();

        public IngridientStorage()
        {
            Ingridients.Add(new Ingridient(1, "Wheat flour", "Sieve. Add to other ingredients"));
            Ingridients.Add(new Ingridient(2, "Coconut flour", "Sieve. Add to other ingredients"));
            Ingridients.Add(new Ingridient(3, "Butter", "Melt on low heat. Add to other ingredients"));
            Ingridients.Add(new Ingridient(4, "Chocolate", "Melt in a water bath. Add to other ingredients"));
            Ingridients.Add(new Ingridient(5, "Sugar", "Add to other ingredients"));
            Ingridients.Add(new Ingridient(6, "Cardamon", "Take half a teaspoon. Add to other ingredients"));
            Ingridients.Add(new Ingridient(7, "Cinnamon", "Take half a teaspoon. Add to other ingredients"));
            Ingridients.Add(new Ingridient(8, "Cocoa powder", "Add to other ingredients"));
        }

        public void Print()
        {
            Console.WriteLine("***** Available ingredients are: *****");
            foreach (var ingridient in Ingridients)
            {
                Console.WriteLine($"{ingridient.Id} {ingridient.Name}");
            }
            Console.WriteLine("**************************************");
        }

        public List<int> IdList()
        {
            return Ingridients.Select(i => i.Id).ToList();
        }

        public Ingridient FindIngridient (int id)
        {
            return Ingridients.Where(i => i.Id == id).FirstOrDefault();
        }

    }
}
