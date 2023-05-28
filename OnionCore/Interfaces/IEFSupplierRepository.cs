using OnionCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCore.Interfaces
{
    public interface IEFSupplierRepository
    {
        public void AddSupplier(Supplier invoice);
    }
}
