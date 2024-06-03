using System.Text.Json;
using Udemi_CookieCookbook.Model;

namespace Udemi_CookieCookbook.WorkWithFiles
{
    public class JsonFile : OperatingFilePattern
    {

        public JsonFile(string fileName, FileFormat fileFormat) : base(fileName, fileFormat)
        {
        }

        public override string ConvertRecipeToStr(Recipe recipe)
        {
            return JsonSerializer.Serialize(recipe.IdList());
        }

        public override string[] ConvertStrToIdList(string textLine)
        {
            var list = JsonSerializer.Deserialize<List<int>>(textLine);
            var result = list.Select(x => x.ToString()).ToArray();
            return result;
        }
    }
}
