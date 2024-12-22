using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemi_TicketsDataAggregate_FromPDF.Model
{
    internal class TicketAggregator
    {
        private const string Path = @"C:\PROGRAMMING\C_Sharp_TechReturners\SmallCsharpExamples\Udemi_TicketsDataAggregate_FromPDF\Tickets";

        public void Run()
        {
            var ticketFolder = new Folder(Path);
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

            var txtFile = new TxtFile("tickets.txt", Path);
            txtFile.WriteTickets(tickets);
        }
    }
}
