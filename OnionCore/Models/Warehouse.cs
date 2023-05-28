using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCore.Models
{
    public class Warehouse
    {
        public int WarehouseId { get; set; }
        public ICollection<Stock> Stocks { get; set; }


    }

}
