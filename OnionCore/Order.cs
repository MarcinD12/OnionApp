using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCore
{
    public class Order
    {
        public OrderTypes OrderType { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public int Cost { get; set; }
    }
    public enum OrderTypes
    {
        Buy,
        Sell
    }
}
