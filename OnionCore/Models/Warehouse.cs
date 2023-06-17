using System.Text.Json.Serialization;
namespace OnionCore.Models
{
    public class Warehouse
    {
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        [JsonIgnore]
        public ICollection<Stock> Stocks { get; set; }


    }

}
