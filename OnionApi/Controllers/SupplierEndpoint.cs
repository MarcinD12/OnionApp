using Application;
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
        public void AddSupplier(Supplier supplier)
        {
            supplierService.AddSupplier(supplier);
        }

        [Authorize(Roles = "admin")]
        [HttpDelete("api/suppliers/delete")]
        public void DeletePart(int partId)
        {
            supplierService.RemoveSupplier(partId);
        }
        [Authorize(Roles = "user")]
        [HttpGet("api/suppliers/all")]
        public string GetSuppliers()
        {
            var suppliers = supplierService.GetSuppliers();
            return suppliers;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
