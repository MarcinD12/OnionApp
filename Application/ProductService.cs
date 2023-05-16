using OnionCore.Interfaces;
using OnionCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ProductService : IProductService
    {
        private readonly IEFProductRepository eFProductRepository;
        public ProductService(IEFProductRepository productRepository)
        {
            eFProductRepository = productRepository;
        }
        public void AddProduct(Product product)
        {
            
        }
        

       
    }
}
