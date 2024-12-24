using Udemi_TicketsDataAggregate_FromPDF.Model;

namespace Udemi_TicketsDataAggregate_FromPDF.Extensions
{
    internal static class TicketsExtractionFromTxt
    {
        public static List<Ticket> ExtractTicketsData(this IEnumerable<string> text)
        {
            List<Ticket> tickets = new List<Ticket>();
            foreach (var pageText in text)
            {
                tickets.AddRange(ExtractTicketsDataFromOnePage(pageText));
            }
            return tickets;
        }

        public static List<Ticket> ExtractTicketsDataFromOnePage(string text)
        {
            var tickets = new List<Ticket>();
            var listOfItems = text.Split(new[] { "Title:", "Date:", "Time:", "Visit us:" }, StringSplitOptions.None);
            //0th - non relevant text; tickets data are from 1st till lenght-2 position; last position - url including domain
            var urlData = listOfItems[listOfItems.Length - 1];
            var domain = urlData.ExtractDomain();
            for (int i = 1; i < listOfItems.Count() - 2; i += 3)
            {
                var ticketAsText = new TicketAsTxt(listOfItems[i], listOfItems[i + 1], listOfItems[i + 2], domain);
                var t = ticketAsText.Convert();
                tickets.Add(t);
            }
            return tickets;
        }
    }
}
