using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnionCore.Interfaces;
using OnionCore.Models;

namespace OnionInfrastructure
{
    public class DatabaseContext : IdentityDbContext<UserEntity, UserRole, int>, IEFSupplierRepository, IEFWarehouseRepository, IEFPartRepository, IEFStockRepository
    {
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

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
            Part parttodelete = this.Parts.Find(partId);
            this.Parts.Remove(parttodelete);
            this.SaveChanges();
        }

        //stock
        public void AddStock(Stock stock)
        {
            this.Stocks.Add(stock);
            this.SaveChanges();
        }

        public void RemoveStock(int stockid)
        {
            Stock stockToDelete = this.Stocks.Find(stockid);
            this.Stocks.Remove(stockToDelete);
            this.SaveChanges();
        }

        public void UpdateStock(Stock stock)
        {
            Stock stocktoupdate = this.Stocks.Find(stock.StockId);
            stocktoupdate = stock;
            this.Stocks.Update(stocktoupdate);
            this.SaveChanges();
        }

        public void DeleteStock(int stockId)
        {
            Stock stockToDelete = this.Stocks.Find(stockId);
            this.Stocks.Remove(stockToDelete);
            this.SaveChanges();
        }

        public Stock GetStockDetails(int stockid)
        {
            return this.Stocks.Find(stockid);
        }
        //Suppliers
        public void AddSupplier(Supplier supplier)
        {
            this.Suppliers.Add(supplier);
            this.SaveChanges();
        }

        public void RemoveSupplier(int supplierId)
        {
            Supplier supplierToDelete = this.Suppliers.Find(supplierId);
            this.Suppliers.Remove(supplierToDelete);
            this.SaveChanges();
        }

        public void UpdateSupplier(Supplier supplier)
        {
            Supplier supplierToUpdate = this.Suppliers.Find(supplier.SupplierId);
            supplierToUpdate = supplier;
            this.Suppliers.Update(supplierToUpdate);
            this.SaveChanges();
        }

        public IEnumerable<Supplier> GetSuppliers()
        {
            return this.Suppliers.ToList();
        }
        //warhouse
        public void AddWarehouse(Warehouse warehouse)
        {
            this.Warehouses.Add(warehouse);
            this.SaveChanges();
        }

        public Warehouse GetWarehouseById(int id)
        {
            return this.Warehouses.Find(id);
        }


    }
}
