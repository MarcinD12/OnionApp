using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnionCore.Interfaces;
using OnionCore.Models;

namespace OnionApi.Controllers
{
    [Authorize(Policy = "Bearer")]
    public class SupplierEndpoint : Controller
    {
        private readonly ISupplierService supplierService;

        public SupplierEndpoint(ISupplierService supplierService)
        {
            this.supplierService = supplierService;
        }
        [Authorize(Roles = "admin")]
        [HttpGet("api/suppliers/add")]
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
