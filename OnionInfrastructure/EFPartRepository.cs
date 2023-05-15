using Microsoft.EntityFrameworkCore;
using OnionCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionInfrastructure
{
    public class EFPartRepository: DbContext,IEFPartRepository
    {
        public virtual DbSet<Part> Parts { get; set; }
        public EFPartRepository(DbContextOptions<EFPartRepository> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
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
    }
}
