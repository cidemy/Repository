﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NYP01
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        public double UnitPrice { get; set; }
        public int CategoryId { get; set; }
        public int UnitInStock { get; set; }

    }
}
