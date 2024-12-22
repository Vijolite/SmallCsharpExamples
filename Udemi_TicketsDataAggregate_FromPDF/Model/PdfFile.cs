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
            var indexOfFirstTitle = text.IndexOf("Title:");
            var indexOfVisitUs = text.IndexOf("Visit us:");
            var UrlData = text.Substring(indexOfVisitUs);
            var UrlDataSeparated = UrlData.Split(".");
            var country = UrlDataSeparated[UrlDataSeparated.Length - 1];
            var ticketsData = text.Substring(indexOfFirstTitle, indexOfVisitUs - indexOfFirstTitle);
            //take away first Title: (6 chars)
            ticketsData = ticketsData.Substring(6);
            string[] ticketsSeparate = ticketsData.Split("Title:");
            foreach (var ticket in ticketsSeparate)
            {
                var ticketAsText = new TicketAsTxt(ticket, country);
                var t = ticketAsText.Convert();
                tickets.Add(t);
            }
            return tickets;
        }
    }
}
