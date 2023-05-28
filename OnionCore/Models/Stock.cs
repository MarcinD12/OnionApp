using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCore.Models
{
    public class Stock
    {
        public int ProductId { get; set; }
        public int ProductStock { get; set; }

        public ICollection<Part> Parts { get; set; }

        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
