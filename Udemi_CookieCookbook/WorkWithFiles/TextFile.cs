using Udemi_CookieCookbook.Model;

namespace Udemi_CookieCookbook.WorkWithFiles
{
    public class TextFile : OperatingFilePattern
    {
        private const string separator = ",";

        public TextFile (string fileName, FileFormat fileFormat) : base (fileName, fileFormat)
        {
        }

        public override string ConvertRecipeToStr(Recipe recipe)
        {
            return string.Join(separator, recipe.IdList());
        }

        public override string[] ConvertStrToIdList(string textLine)
        {
            return textLine.Split(separator);
        }
    }
}
