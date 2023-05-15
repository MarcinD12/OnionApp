using Microsoft.EntityFrameworkCore;
using OnionCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionInfrastructure
{
    public class EFProductRepository : DbContext, IEFProductRepository
    {
        public virtual DbSet<Product> Products { get; set; }

        public EFProductRepository(DbContextOptions<EFProductRepository> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            


        }
    }
}
