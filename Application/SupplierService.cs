using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionCore.Interfaces;
using OnionCore.Models;
using OnionCore;
namespace Application
{
    public class SupplierService : ISupplierService
    {
        private readonly IEFSupplierRepository _EFInvoiceRepository;
        public SupplierService(IEFSupplierRepository EFInvoiceRepository)
        {
            _EFInvoiceRepository = EFInvoiceRepository;
        }
        public void AddSupplier(Supplier invoice)
        {
            _EFInvoiceRepository.AddSupplier(invoice);
        }
    }
}
