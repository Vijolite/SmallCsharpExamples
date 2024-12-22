namespace Udemi_TicketsDataAggregate_FromPDF.Model
{
    internal class Ticket
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }

        public Ticket (string title, DateTime date)
        {
            Title = title;
            Date = date;
        }

        public void Print()
        {
            Console.WriteLine($"{Title} {Date}");
        }

        public string ToString()
        {
            return $"{Title} {Date}";
        }

    }

}
