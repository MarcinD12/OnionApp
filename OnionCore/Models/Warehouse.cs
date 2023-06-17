namespace OnionCore.Models
{
    public class Warehouse
    {
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public ICollection<Stock> Stocks { get; set; }


    }

}
