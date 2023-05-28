using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionCore.Models;

namespace OnionCore.Interfaces
{
    public interface IWarehouseService
    {
        public void AddWarehouse(Warehouse warehouse);
        public Warehouse GetWarehouseById(int id);

    }
}
