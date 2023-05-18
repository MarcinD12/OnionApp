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
    public class InvoiceService : IInvoiceService
    {
        private readonly IEFInvoiceRepository _EFInvoiceRepository;
        public InvoiceService(IEFInvoiceRepository EFInvoiceRepository)
        {
            _EFInvoiceRepository = EFInvoiceRepository;
        }
        public void AddInvoice(Invoice invoice)
        {
            _EFInvoiceRepository.AddInvoice(invoice);
        }
    }
}
