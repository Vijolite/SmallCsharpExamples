namespace Udemi_CookieCookbook.WorkWithFiles
{
    public static class FileFormatExtensions
    {
        public static string AsFileExtension (this FileFormat fileformat) => fileformat == FileFormat.Txt ? "txt" : "json";
        public static OperatingFilePattern CreateNewFile(this FileFormat fileformat, string fileName) =>
            fileformat == FileFormat.Txt ? new TextFile(fileName, fileformat) : new JsonFile(fileName, fileformat);
    }
}
