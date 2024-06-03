namespace Udemi_CookieCookbook.WorkWithFiles
{
    public static class FileFormatExtensions
    {
        public static string AsFileExtension (this FileFormat fileformat) => fileformat == FileFormat.Txt ? "txt" : "json";

        public static IOperatingFile CreateNewFile (this FileFormat fileformat, string fileName) => 
            fileformat == FileFormat.Txt ? new TextFile(fileName) : new JsonFile(fileName);
    }
}
