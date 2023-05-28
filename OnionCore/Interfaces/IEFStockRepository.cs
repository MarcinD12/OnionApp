using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionCore.Models;

namespace OnionCore.Interfaces
{
    public interface IEFStockRepository
    {
        public void AddStock(Stock stock);
        public void UpdateStock(Stock stock);
        public void DeleteStock(int stockid);
        public Stock GetStockDetails(int stockid);
    }
}
