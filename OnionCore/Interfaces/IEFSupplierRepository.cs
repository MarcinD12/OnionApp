using OnionCore.Models;

namespace OnionCore.Interfaces
{
    public interface IEFSupplierRepository
    {
        public void AddSupplier(Supplier supplier);
        public void RemoveSupplier(int supplierId);

        public void UpdateSupplier(Supplier supplier);
        public List<Supplier> GetSuppliers();

    }
}
