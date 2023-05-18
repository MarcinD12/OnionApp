using Microsoft.AspNetCore.Mvc;
using OnionCore.Interfaces;
using OnionCore.Models;

namespace OnionApi.Controllers
{
    public class InvoiceEndpoint : Controller
    {
        private readonly IInvoiceService invoiceService;

        public InvoiceEndpoint(IInvoiceService invoiceService)
        {
            this.invoiceService = invoiceService;
        }

        [HttpGet("api/invoices/add")]
        public void AddInvoice(Invoice invoice)
        {
            invoiceService.AddInvoice(invoice);
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
