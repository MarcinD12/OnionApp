namespace OnionCore.Models
{
    public class Part
    {
        public int PartId { get; set; }
        public string PartName { get; set; }
        public int Price { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        public Supplier? Supplier { get; set; }
        public int? SupplierId { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        public ICollection<Stock> Stocks { get; set; }

    }
}
