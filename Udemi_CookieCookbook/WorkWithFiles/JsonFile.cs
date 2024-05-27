using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Udemi_CookieCookbook.Model;

namespace Udemi_CookieCookbook.WorkWithFiles
{
    internal class JsonFile : IOperatingFile
    {
        private string _fileName;

        public JsonFile(string fileName)
        {
            _fileName = fileName;
        }

        public void Append(Recipe recipe)
        {
            using StreamWriter writefile = File.AppendText(_fileName);
            writefile.WriteLine(JsonSerializer.Serialize(recipe.IdList()));
            writefile.Close();
        }

        public RecipeStorage ReadAll(string path, IngridientStorage ingStorage)
        {
            IEnumerable<string> lines = File.ReadLines(_fileName);
            List<Recipe> recipeList = new List<Recipe>();
            foreach (var line in lines)
            {
                var idList = JsonSerializer.Deserialize<List<int>>(line);
                List<Ingridient> listOfIngridients = idList.Select(id => ingStorage.FindIngridient(id)).ToList();
                recipeList.Add(new Recipe(listOfIngridients));
            }
            return new RecipeStorage(recipeList);
        }
    }
}
