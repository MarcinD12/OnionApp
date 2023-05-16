﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCore.Models
{
    public class Part
    {
        public int PartId { get; set; }
        public string PartName { get; set; }
        public int Price { get; set; }
        public int PartStock { get; set; }
        public List<Product> Products { get; set; }

    }
}