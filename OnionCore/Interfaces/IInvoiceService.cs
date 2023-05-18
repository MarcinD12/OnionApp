using OnionCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCore.Interfaces
{
    public interface IInvoiceService
    {
        public void AddInvoice(Invoice invoice);
    }
}
