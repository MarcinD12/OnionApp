using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using OnionCore.Interfaces;
using OnionCore.Models;

namespace OnionInfrastructure
{
    public class EFInvoiceRepository : DbContext, IEFInvoiceRepository
    {
        public virtual DbSet<Invoice> Invoices { get; set; }

        public EFInvoiceRepository(DbContextOptions<EFInvoiceRepository> options) : base(options)
        {
           
        }
        protected override void OnModelCreating (ModelBuilder builder)
        {
            base.OnModelCreating (builder);

        }

        public void AddInvoice(Invoice invoice)
        {
            this.Invoices.Add(invoice);
            this.SaveChanges();
        }
    }
}
