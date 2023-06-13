namespace OnionCore.Models
{
    public class Stock
    {
        public int StockId { get; set; }
        public int PartId { get; set; }
        public Part Part { get; set; }
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
