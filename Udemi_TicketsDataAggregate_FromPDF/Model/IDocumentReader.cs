namespace Udemi_TicketsDataAggregate_FromPDF.Model
{
    internal interface IDocumentReader
    {
        public IEnumerable<string> Read(string folderName);
    }
}
