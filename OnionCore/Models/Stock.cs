
using System.Text.Json.Serialization;

namespace OnionCore.Models
{
    public class Stock
    {
        public int StockId { get; set; }
        public int PartId { get; set; }
        [JsonIgnore]
        public Part Part { get; set; }
        public int WarehouseId { get; set; }
        [JsonIgnore]
        public Warehouse Warehouse { get; set; }
    }
}
