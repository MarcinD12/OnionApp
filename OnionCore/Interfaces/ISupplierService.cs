using OnionCore.Models;

namespace OnionCore.Interfaces
{
    public interface ISupplierService
    {
        public void AddSupplier(Supplier supplier);
        public void RemoveSupplier(int supplierId);
        public void UpdateSupplier(Supplier supplier);
        public string GetSuppliers();

    }
}
