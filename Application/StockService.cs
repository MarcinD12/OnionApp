﻿using OnionCore.Interfaces;
using OnionCore.Models;

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
    }
}
