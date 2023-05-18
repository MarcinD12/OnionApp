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
    public class DatabaseContext : DbContext, IEFInvoiceRepository, IEFOrderRepository,IEFPartRepository,IEFProductRepository
    {
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext>options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }

        //Product

        public void AddProduct(Product product)
        {
            this.Products.Add(product);
        }

        //Order

        public void addOrderToDatabase(Order order)
        {
            Console.WriteLine(order.Cost);
            this.Orders.Add(order);
            this.SaveChanges();
        }

        public List<Order> GetAllOrders()
        {
            var allorders = this.Orders.ToList();
            foreach (var order in allorders) { Console.WriteLine(order.OrderType); }
            return allorders;
        }

        public Order GetOrderById(int id)
        {
            Order order = this.Orders.Find(id);
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

        public void AddInvoice(Invoice invoice)
        {
            this.Invoices.Add(invoice);
            this.SaveChanges();
        }

    }
}
