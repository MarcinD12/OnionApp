using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCore
{
    internal class Warehouse
    {
        public int ItemId { get; set; }
        public ItemTypes ItemType { get; set; }
        public int Quantity { get; set; }
    }
    public enum ItemTypes
    {
        Part,
        Product
    }
}
