using System;
using System.Globalization;

namespace Udemi_TicketsDataAggregate_FromPDF.Model
{
    internal class TicketAsTxt
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Country { get; set; }

        public TicketAsTxt (string ticketData, string country)
        {
            var titleAndDatetime = ticketData.Split("Date:");
            Title = titleAndDatetime[0];
            var dateAndTime = titleAndDatetime[1].Split("Time:");
            Date = dateAndTime[0];
            Time = dateAndTime[1];
            Country = country;
        }

        public void Print()
        {
            Console.WriteLine($"{Title} {Date} {Time} {Country}");
        }

        public Ticket Convert()
        {
            var culture = Country
            switch
            {
                "com" => "en-US",
                "jp" => "ja-JP",
                "fr" => "fr-FR",
                _ => ""
            };
            var date = Convert(Date + " " + Time, culture);
            
            return new Ticket(Title, date);
        }

        private static DateTime Convert (string text, string culture)
        {
            var cultureInfo = new CultureInfo(culture);
            var dateTime = DateTime.Parse(text, cultureInfo);
            return dateTime;
        }

    }
}
