namespace OnionCore.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }

        public ICollection<Part> Parts { get; set; }

    }
}
