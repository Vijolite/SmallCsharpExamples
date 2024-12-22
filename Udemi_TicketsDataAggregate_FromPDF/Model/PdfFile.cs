using UglyToad.PdfPig.Content;
using UglyToad.PdfPig;

namespace Udemi_TicketsDataAggregate_FromPDF.Model
{
    internal class PdfFile
    {
        public string FileName { get; set; }

        public PdfFile (string fileName)
        {
            FileName = fileName;
        }

        public List<Ticket> ReadWholeFile()
        {
            var tickets = new List<Ticket>();
            using (PdfDocument document = PdfDocument.Open(FileName))
            {
                foreach (Page page in document.GetPages())
                {
                    string pageText = page.Text;

                    //Console.WriteLine(pageText);

                    tickets.AddRange(ExtractTicketsData(pageText));

/*                    foreach (Word word in page.GetWords())
                    {
                        Console.WriteLine(word.Text);
                    }*/
                }
                return tickets;
            }
        }

        public List<Ticket> ExtractTicketsData (string text)
        {
            var tickets = new List<Ticket>();
            var listOfItems = text.Split(new[] { "Title:", "Date:", "Time:" , "Visit us:"}, StringSplitOptions.None);
            //0th - non relevant text; tickets data are from 1st till lenght-2 position; last position - url including country
            var UrlData = listOfItems[listOfItems.Length - 1];
            var UrlDataSeparated = UrlData.Split(".");
            var country = UrlDataSeparated[UrlDataSeparated.Length - 1];
            for (int i = 1; i < listOfItems.Count()-2; i+=3)
            {
                var ticketAsText = new TicketAsTxt(listOfItems[i], listOfItems[i + 1], listOfItems[i + 2], country);
                var t = ticketAsText.Convert();
                tickets.Add(t);
            }
            return tickets;
        }
    }
}
