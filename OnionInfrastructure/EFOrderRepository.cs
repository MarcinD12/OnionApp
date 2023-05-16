using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OnionCore.Interfaces;
using OnionCore.Models;

namespace OnionInfrastructure
{
    public class EFOrderRepository : DbContext, IEFOrderRepository
    {
        public virtual DbSet<Order> Orders { get; set; }
        
        public EFOrderRepository(DbContextOptions<EFOrderRepository> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
           builder.Entity<Order>().HasOne(x=>x.Invoice).WithOne(x=>x.Order).HasForeignKey<Invoice>(x=>x.OrderId);
        }

        public void addOrderToDatabase(Order order)
        {
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
    }
}
