using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCore
{
    public class Product
    {
        public int ProductId { get; set; }
        public List<Part> Parts { get; set; }
        public int Price { get; set; }

    }
}
