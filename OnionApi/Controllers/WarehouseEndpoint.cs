using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnionCore.Interfaces;
using OnionCore.Models;

namespace OnionApi.Controllers
{
    [Authorize(Policy = "Bearer")]
    public class WarehouseEndpoint : Controller
    {

        private readonly IWarehouseService _warehouseService;
        public WarehouseEndpoint(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;

        }
        [Authorize(Roles = "admin")]
        [HttpPost("api/warehouses/add")]
        public void AddWarehouse(Warehouse warehouse)
        {
            _warehouseService.AddWarehouse(warehouse);
        }
        [Authorize(Roles = "user")]
        [HttpGet("api/warehouses/detailds")]
        public Warehouse GetDetails(int id)
        {
            return _warehouseService.GetWarehouseById(id);

        }







    }
}
