namespace OnionCore.Models
{
    public class Part
    {
        public int PartId { get; set; }
        public string PartName { get; set; }
        public int Price { get; set; }

        public Supplier? Supplier { get; set; }
        public int? SupplierId { get; set; }

        public ICollection<Stock> Stocks { get; set; }

    }
}
