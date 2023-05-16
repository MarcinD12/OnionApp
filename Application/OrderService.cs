using OnionCore.Interfaces;
using OnionCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class OrderService : IOrderService
    {

        private readonly IEFOrderRepository _EFOrderRepository;
        public OrderService(IEFOrderRepository orderRepository)
        {
         _EFOrderRepository= orderRepository;
        }

        public void AddOrder(Order order)
        {
           
            Console.WriteLine(order.OrderType);
            _EFOrderRepository.addOrderToDatabase(order);
        }

        public List<Order> GetAllOrders()
        {
            var res = _EFOrderRepository.GetAllOrders();
           
            return res;
        }

        public Order GetOrderById(int id)
        {
            Order order = _EFOrderRepository.GetOrderById(id);
            return order;
        }
    }
}
