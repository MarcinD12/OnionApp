using OnionCore.Models;

namespace OnionCore.Interfaces
{
    public interface IEFWarehouseRepository
    {
        public void AddWarehouse(Warehouse warehouse);
        public Warehouse GetWarehouseById(int id);
    }
}
