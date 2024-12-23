namespace Udemi_TicketsDataAggregate_FromPDF.Model
{
    internal class Ticket
    {
        public string Title { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }

        public Ticket (string title, DateOnly date, TimeOnly time)
        {
            Title = title;
            Date = date;
            Time = time;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

        public string ToString()
        {
            return $"Title: {Title,-20} || Date: {Date,-12} || Time: {Time,-10}";
        }

    }

}
