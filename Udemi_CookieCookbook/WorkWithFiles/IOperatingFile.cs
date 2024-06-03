using Udemi_CookieCookbook.Model;

namespace Udemi_CookieCookbook.WorkWithFiles
{
    public interface IOperatingFile
    {
        public void Append(Recipe recipe);

        public RecipeStorage ReadAll(IIngridientStorage ingStorage);

        public bool Exist();
    }
}
