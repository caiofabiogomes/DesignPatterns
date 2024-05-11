using DesignPatterns.Facade.Services;

namespace DesignPatterns.Facade.Facade
{
    public class OrderFacade
    {
        private readonly ProductService _productService;
        private readonly CustomerService _customerService;
        private readonly PdfReportGeneratorService _pdfReportGeneratorService;

        public OrderFacade()
        {
            _productService = new ProductService();
            _customerService = new CustomerService();
            _pdfReportGeneratorService = new PdfReportGeneratorService();
        }


        public async Task GenerateOrderReport(int customerId, int productId)
        {
            string customerDetails = await _customerService.GetCustomerDetailsFromApi(customerId);
            string productDetails = await _productService.GetProductDetailsFromApi(productId);

            _pdfReportGeneratorService.GenerateReport(customerDetails, productDetails);
        }
    }
}
