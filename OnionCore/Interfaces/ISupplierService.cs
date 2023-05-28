using OnionCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCore.Interfaces
{
    public interface ISupplierService
    {
        public void AddSupplier(Supplier supplier);
        public void RemoveSupplier(int supplierId);
        public void UpdateSupplier(Supplier supplier);
        public IEnumerable<Supplier> GetSuppliers();

    }
}
