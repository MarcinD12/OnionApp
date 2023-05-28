using Microsoft.AspNetCore.Mvc;
using OnionCore.Interfaces;
using OnionCore.Models;

namespace OnionApi.Controllers
{
    public class SupplierEndpoint : Controller
    {
        private readonly ISupplierService supplierService;

        public SupplierEndpoint(ISupplierService invoiceService)
        {
            this.supplierService = invoiceService;
        }

        [HttpGet("api/invoices/add")]
        public void AddSupplier(Supplier invoice)
        {
            supplierService.AddSupplier(invoice);
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
