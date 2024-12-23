using System.Globalization;

namespace Udemi_TicketsDataAggregate_FromPDF.Model
{
    internal class TicketAsTxt
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Domain { get; set; }

        private Dictionary<string, string> _culture = new Dictionary<string, string> 
        { ["com"] = "en-US", ["jp"] = "ja-JP", ["fr"] = "fr-FR" };

        public TicketAsTxt(string title, string date, string time, string domain)
        {
            Title = title;
            Date = date;
            Time = time;
            Domain = domain;
        }

        public void Print()
        {
            Console.WriteLine($"{Title} {Date} {Time} {Domain}");
        }

        public Ticket Convert()
        {
            var cultureInfo = new CultureInfo(_culture[Domain]);
            var date = DateOnly.Parse(Date, cultureInfo);
            var time = TimeOnly.Parse(Time, cultureInfo);
                    
            return new Ticket(Title, date, time);
        }

    }
}
