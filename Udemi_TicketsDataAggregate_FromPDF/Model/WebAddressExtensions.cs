namespace Udemi_TicketsDataAggregate_FromPDF.Model
{
    public static class WebAddressExtensions
    {
        public static string ExtractDomain(this string url)
        {
            var dotIndex = url.LastIndexOf(".");
            var domain = url.Substring(dotIndex + 1);
            return domain;
        }
    }

}
