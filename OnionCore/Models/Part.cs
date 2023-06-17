using System.Text.Json.Serialization;
namespace OnionCore.Models
{
    public class Part
    {
        public int PartId { get; set; }
        public string PartName { get; set; }
        public int Price { get; set; }
        [JsonIgnore]
        public Supplier? Supplier { get; set; }
        public int? SupplierId { get; set; }
        [JsonIgnore]
        public ICollection<Stock> Stocks { get; set; }

    }
}
