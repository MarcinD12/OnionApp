using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCore.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        
        public DateTime InvoiceDate { get; set; }
        public string SubjectId { get; set; }
        public int AmountToPay { get; set; }
        public int OrderId { get; set; }
        
    }
}
