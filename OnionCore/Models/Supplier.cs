using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCore.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }

        public ICollection<Part> Parts { get; set; }

    }
}
