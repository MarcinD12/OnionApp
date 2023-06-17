using OnionCore.Interfaces;
using OnionCore.Models;
using System.Text.Json;
namespace Application
{
    public class SupplierService : ISupplierService
    {
        private readonly IEFSupplierRepository _EFSupplierRepository;
        public SupplierService(IEFSupplierRepository EFInvoiceRepository)
        {
            _EFSupplierRepository = EFInvoiceRepository;
        }
        public void AddSupplier(Supplier invoice)
        {
            _EFSupplierRepository.AddSupplier(invoice);
        }

        public string GetSuppliers()
        {
            var suppliers= _EFSupplierRepository.GetSuppliers();
            return JsonSerializer.Serialize(suppliers);
        }

        public void RemoveSupplier(int supplierId)
        {
            _EFSupplierRepository.RemoveSupplier(supplierId);
        }

        public void UpdateSupplier(Supplier supplier)
        {
            _EFSupplierRepository.UpdateSupplier(supplier);
        }

        
    }
}
