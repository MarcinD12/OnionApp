using OnionCore.Models;

namespace OnionCore.Interfaces
{
    public interface IStockService
    {
        public void AddStock(Stock stockId);
        public void UpdateStock(Stock stockId);
        public void DeleteStock(int stockId);
        public Stock GetStockDetails(int stockid);


    }
}
