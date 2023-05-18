using Application;
using Microsoft.AspNetCore.Mvc;
using OnionCore.Interfaces;
using OnionCore.Models;
using OnionInfrastructure;
using System.Text.Json;

namespace OnionApi.Controllers
{
    public class OrderEndpoint : Controller
    {

        private readonly IOrderService _orderService;
        public OrderEndpoint(IOrderService orderService)
        {
            _orderService = orderService;
 
        }

        [HttpGet("api/orders/all")]
        public string GetAllOrders()
        {
            var allOrders= _orderService.GetAllOrders();
            
            return  JsonSerializer.Serialize(allOrders);
        }

        [HttpGet("api/orders/")]
        public string GetOrderById(int id) {
            var orderbyid = _orderService.GetOrderById(id);
            return JsonSerializer.Serialize(orderbyid);
        }

        [HttpPost("api/orders/add")]
        public void AddOrder(Order order)
        {
            Console.WriteLine(ModelState.IsValid);
            Console.WriteLine(order.Cost);
            _orderService.AddOrder(order);
        }


    }
}
