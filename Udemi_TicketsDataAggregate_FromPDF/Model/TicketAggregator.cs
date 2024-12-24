namespace Udemi_TicketsDataAggregate_FromPDF.Model
{
    internal class TicketAggregator
    {
        private const string Path = @"C:\PROGRAMMING\C_Sharp_TechReturners\SmallCsharpExamples\Udemi_TicketsDataAggregate_FromPDF\Tickets";

        public void Run()
        {
            var ticketFolder = new FolderReader();
            var textDataFromPdfFiles = ticketFolder.Read(Path);

            var tickets = textDataFromPdfFiles.ExtractTicketsData();

            PrintAllTicketsToScreen(tickets);

            var txtFile = new TxtFile("tickets.txt", Path);
            txtFile.WriteTickets(tickets);
        }


        public static void PrintAllTicketsToScreen (List<Ticket> tickets)
        {
            Console.WriteLine("***");
            foreach (var t in tickets)
            {
                t.Print();
            }
        }
    }
}
