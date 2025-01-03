﻿using Udemi_TicketsDataAggregate_FromPDF.Model;

namespace Udemi_TicketsDataAggregate_FromPDF.WorkWithFiles
{
    internal class TxtFile
    {
        public string FileName { get; set; }

        public string Folder { get; set; }

        public TxtFile(string fileName, string folder)
        {
            FileName = fileName;
        }

        public void WriteTickets(List<Ticket> tickets)
        {
            string fullPath = Folder + FileName;
            var ticketsAsStrings = tickets.Select(t => t.ToString());
            File.WriteAllLines(fullPath, ticketsAsStrings);
        }
    }

}
