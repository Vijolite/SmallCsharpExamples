namespace Udemi_TicketsDataAggregate_FromPDF.Model
{
    internal class Folder
    {
        public string Path { get;set; }

        public Folder(string path)
        {
            Path = path;
        }

        public string[] GetPdfFiles()
        {
            try
            {
                // Only get pdf files
                string[] files = Directory.GetFiles(Path, "*pdf");
                Console.WriteLine("The number of PDF files is {0}.", files.Length);
                return files;
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
                throw e;
            }
        }
    }
}
