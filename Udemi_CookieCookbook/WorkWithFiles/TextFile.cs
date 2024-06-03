using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemi_CookieCookbook.Model;

namespace Udemi_CookieCookbook.WorkWithFiles
{
    public class TextFile : IOperatingFile
    {
        private string _fileName;

        public TextFile (string fileName)
        {
            _fileName = fileName;
        }

        public void Append(Recipe recipe)
        {
            using StreamWriter writefile = File.AppendText(_fileName);
            writefile.WriteLine(string.Join(",", recipe.IdList()));
            writefile.Close();
        }

        public RecipeStorage ReadAll (IIngridientStorage ingStorage)
        {
            IEnumerable<string> lines = File.ReadLines(_fileName);
            List<Recipe> recipeList = new List<Recipe>();
            foreach (var line in lines)
            {
                var idList = line.Split(",");
                List<Ingridient> listOfIngridients = idList.Select(id => ingStorage.FindIngridient(Convert.ToInt32(id))).ToList();
                recipeList.Add(new Recipe(listOfIngridients));
            }
            return new RecipeStorage(recipeList);
        }

        public bool Exist()
        {
            return File.Exists(_fileName);
        }
        
    }
}
