using Udemi_TicketsDataAggregate_FromPDF.Model;

try
{
    var ticketAggregator = new TicketAggregator();
    ticketAggregator.Run();
}
catch (Exception ex)
{
    Console.WriteLine("An exception occured ", ex.Message);
}
