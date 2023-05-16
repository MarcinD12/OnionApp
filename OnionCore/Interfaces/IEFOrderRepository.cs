﻿using Microsoft.AspNetCore.Mvc;
using OnionCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCore.Interfaces
{
    public interface IEFOrderRepository
    {
        public void addOrderToDatabase(Order order);
        public List<Order> GetAllOrders();
        public Order GetOrderById(int id);
    }
}