namespace DesignPatterns.Facade.Services
{
    public class PdfReportGeneratorService
    {
        public void GenerateReport(string customerInfo, string productInfo)
        {
            Console.WriteLine("Generating PDF report");
            Console.WriteLine(customerInfo);
            Console.WriteLine(productInfo);
            Console.WriteLine("-------------------------------");
        }
    }
}
