using UglyToad.PdfPig.Content;
using UglyToad.PdfPig;

namespace Udemi_TicketsDataAggregate_FromPDF.Model
{
    internal class FolderReader : IDocumentReader
    {
        private string[] GetPdfFiles(string folderName)
        {
            try
            {
                // Only get pdf files
                string[] files = Directory.GetFiles(folderName, "*pdf");
                Console.WriteLine("The number of PDF files is {0}.", files.Length);
                return files;
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
                throw e;
            }
        }

        public IEnumerable<string> Read(string folderName)
        {
            var allPdfFilesNames = this.GetPdfFiles(folderName);

            foreach (var fileName in allPdfFilesNames)
            {
                using (PdfDocument document = PdfDocument.Open(fileName))
                {
                    foreach (Page page in document.GetPages())
                    {
                        string pageText = page.Text;
                        yield return pageText;

                        /*                    foreach (Word word in page.GetWords())
                                            {
                                                Console.WriteLine(word.Text);
                                            }*/
                    }
                }
            }

        }
    }
}
