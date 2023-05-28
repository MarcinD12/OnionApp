using Microsoft.AspNetCore.Mvc;
using OnionCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCore.Interfaces
{
    public interface IEFWarehouseRepository
    {
        public void AddWarehouse(Warehouse warehouse);
        public Warehouse GetWarehouseById(int id);
    }
}
