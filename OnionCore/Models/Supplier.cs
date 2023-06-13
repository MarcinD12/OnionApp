namespace OnionCore.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public ICollection<Part> Parts { get; set; }

    }
}
