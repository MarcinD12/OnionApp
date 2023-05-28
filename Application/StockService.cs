using OnionCore.Interfaces;
using OnionCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class StockService : IStockService
    {
        private readonly IEFStockRepository eFProductRepository;
        public StockService(IEFStockRepository productRepository)
        {
            eFProductRepository = productRepository;
        }

        public void AddStock(Stock product)
        {
            throw new NotImplementedException();
        }
    }
}
