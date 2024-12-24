namespace Udemi_TicketsDataAggregate_FromPDF.WorkWithFiles
{
    internal interface IDocumentReader
    {
        public IEnumerable<string> Read(string folderName);
    }
}
