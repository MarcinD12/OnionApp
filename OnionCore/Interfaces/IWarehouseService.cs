using OnionCore.Models;

namespace OnionCore.Interfaces
{
    public interface IWarehouseService
    {
        public void AddWarehouse(Warehouse warehouse);
        public Warehouse GetWarehouseById(int id);
        public void RemoveWarehouse(Warehouse warehouse);
    }
}
