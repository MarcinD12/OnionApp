using OnionCore.Interfaces;
using OnionCore.Models;
using System.Text.Json;

namespace Application
{
    public class StockService : IStockService
    {
        private readonly IEFStockRepository eFStockRepository;
        public StockService(IEFStockRepository productRepository)
        {
            eFStockRepository = productRepository;
        }

        public void AddStock(Stock product)
        {
            eFStockRepository.AddStock(product);
        }

        public void DeleteStock(int stockid)
        {
            eFStockRepository.DeleteStock(stockid);
        }


        public void UpdateStock(Stock product)
        {
            eFStockRepository.UpdateStock(product);
        }
        public Stock GetStockDetails(int stockid)
        {
            return eFStockRepository.GetStockDetails(stockid);
        }

        public string GetAllStock()
        {
            var allstock= eFStockRepository.GetAllStock();
            return JsonSerializer.Serialize(allstock);
        }
    }
}
