using OnionCore.Interfaces;
using OnionCore.Models;

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

        public void RemoveWarehouse(Warehouse warehouse)
        {
            _EFWarehouseRepository.RemoveWarehouse(warehouse);
        }
    }
}
