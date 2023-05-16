using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionCore.Models;

namespace OnionCore.Interfaces
{
    public interface IOrderService
    {
        public void AddOrder(Order order);
        public List<Order> GetAllOrders();
        public Order GetOrderById(int id);
    }
}
