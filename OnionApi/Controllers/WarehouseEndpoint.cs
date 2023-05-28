using Application;
using Microsoft.AspNetCore.Mvc;
using OnionCore.Interfaces;
using OnionCore.Models;
using OnionInfrastructure;
using System.Text.Json;

namespace OnionApi.Controllers
{
    public class WarehouseEndpoint : Controller
    {

        private readonly IWarehouseService _orderService;
        public WarehouseEndpoint(IWarehouseService orderService)
        {
            _orderService = orderService;
 
        }

        //[HttpGet("api/orders/all")]
        //public string GetAllOrders()
        //{
        //    var allOrders= _orderService.GetAllOrders();
            
        //    return  JsonSerializer.Serialize(allOrders);
        //}

        //[HttpGet("api/orders/")]
        //public string GetOrderById(int id) {
        //    var orderbyid = _orderService.GetOrderById(id);
        //    return JsonSerializer.Serialize(orderbyid);
        //}

        //[HttpPost("api/orders/add")]
        //public void AddOrder(Warehouse order)
        //{
        //    Console.WriteLine(ModelState.IsValid);
        //    Console.WriteLine(order.Cost);
        //    _orderService.AddOrder(order);
        //}


    }
}
