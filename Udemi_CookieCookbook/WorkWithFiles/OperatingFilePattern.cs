using Udemi_CookieCookbook.Model;

namespace Udemi_CookieCookbook.WorkWithFiles
{
    public abstract class OperatingFilePattern : IOperatingFile
    {
        private string _fileName;
        private FileFormat _fileFormat;

        public OperatingFilePattern (string fileName, FileFormat fileFormat)
        {
            _fileName = fileName;
            _fileFormat = fileFormat;
        }

        public void Append(Recipe recipe)
        {
            using StreamWriter writefile = File.AppendText(_fileName);
            writefile.WriteLine(ConvertRecipeToStr(recipe));
            writefile.Close();
        }

        public RecipeStorage ReadAll (IIngridientStorage ingStorage)
        {
            IEnumerable<string> lines = File.ReadLines(_fileName);
            List<Recipe> recipeList = new List<Recipe>();
            foreach (var line in lines)
            {
                var idList = ConvertStrToIdList(line);
                List<Ingridient> listOfIngridients = idList.Select(id => ingStorage.FindIngridient(Convert.ToInt32(id))).ToList();
                recipeList.Add(new Recipe(listOfIngridients));
            }
            return new RecipeStorage(recipeList);
        }

        public bool Exist()
        {
            return File.Exists(_fileName);
        }

        public virtual string ConvertRecipeToStr(Recipe recipe)
        {
            return string.Join(",", recipe.IdList());
        }

        public virtual string[] ConvertStrToIdList (string textLine)
        {
            return textLine.Split(",");
        }
        
    }
}
