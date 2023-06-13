using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnionCore.Interfaces;
using OnionCore.Models;

namespace OnionApi.Controllers
{
    [Authorize(Policy = "Bearer")]
    public class StockEndpoint : Controller
    {
        private readonly IStockService _stockService;
        public StockEndpoint(IStockService stockservice)
        {
            _stockService = stockservice;
        }
        [Authorize(Roles = "user")]
        [HttpGet("api/stocks/get")]
        public Stock GetStockDetails(int stockId)
        {
            return _stockService.GetStockDetails(stockId);
        }
        [Authorize(Roles = "user")]
        [HttpPost("api/stocks/add")]
        public void AddStock(Stock stock)
        {
            _stockService.AddStock(stock);
        }
        [Authorize(Roles = "user")]
        [HttpPost("api/stocks/update")]
        public void UpdateStock(Stock stock)
        {
            _stockService.UpdateStock(stock);
        }

    }
}
