using OnionCore.Interfaces;
using OnionCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class WarehouseService : IWarehouseService
    {

        private readonly IEFWarehouseRepository _EFWarehouseRepository;
        public WarehouseService(IEFWarehouseRepository orderRepository)
        {
            _EFWarehouseRepository = orderRepository;
        }

        public void AddWarehouse(Warehouse order)
        {
            _EFWarehouseRepository.AddWarehouse(order);
        }


        public Warehouse GetWarehouseById(int id)
        {
            Warehouse warehouse = _EFWarehouseRepository.GetWarehouseById(id);
            return warehouse;
        }
    }
}
