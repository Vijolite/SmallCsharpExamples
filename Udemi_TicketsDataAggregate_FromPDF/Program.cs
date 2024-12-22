using Udemi_TicketsDataAggregate_FromPDF.Model;

//string path = "C:\\PROGRAMMING\\C_Sharp_TechReturners\\SmallCsharpExamples\\Udemi_TicketsDataAggregate_FromPDF\\Tickets";
string path = "Tickets";
var ticketFolder = new Folder(path);
var pdfFilesNames = ticketFolder.GetPdfFiles();
var tickets = new List<Ticket>();
foreach (var fileName in pdfFilesNames)
{
    var pdfFile = new PdfFile(fileName);
    var ticketsFromOneFile = pdfFile.ReadWholeFile();
    tickets.AddRange(ticketsFromOneFile);
}
Console.WriteLine("***");
foreach (var t in tickets)
{
    t.Print();
}
var txtFile = new TxtFile("tickets.txt", path);
txtFile.WriteTickets(tickets);