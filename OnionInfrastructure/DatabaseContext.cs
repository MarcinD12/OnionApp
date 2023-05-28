using Microsoft.EntityFrameworkCore;
using OnionCore.Interfaces;
using OnionCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionInfrastructure
{
    public class DatabaseContext : DbContext, IEFSupplierRepository, IEFWarehouseRepository,IEFPartRepository,IEFStockRepository
    {
        public virtual DbSet<Supplier> Invoices { get; set; }
        public virtual DbSet<Warehouse> Orders { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<Stock> Products { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext>options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }

        //Product

        public void AddProduct(Stock product)
        {
            this.Products.Add(product);
        }

        //Order





        public Warehouse GetWarehouseDetails(int id)
        {
            Warehouse order = this.Orders.Find(id);
            return order;
        }


        //Part
        public List<Part> GetAllParts()
        {
            var allparts = this.Parts.ToList();
            return allparts;
        }

        public void UpdatePart(int partId, Part part)
        {
            Part partToUpdate = this.Parts.Find(partId);
            partToUpdate = part;
            this.Update(partToUpdate);
            this.SaveChanges();
        }

        public void AddPart(Part part)
        {
            this.Parts.Add(part);
            this.SaveChanges();
        }

        public void DeletePart(int partId)
        {
            this.Remove(partId);
        }

        //invoice

        public void AddInvoice(Supplier invoice)
        {
            this.Invoices.Add(invoice);
            this.SaveChanges();
        }

        public void AddSupplier(Supplier invoice)
        {
            throw new NotImplementedException();
        }

        public void AddWarehouse(Warehouse warehouse)
        {
            throw new NotImplementedException();
        }

        public void AddStock(Stock product)
        {
            throw new NotImplementedException();
        }

        public Warehouse GetWarehouseById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
