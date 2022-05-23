﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Item
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Prise { get; set; }
        public bool Sold { get; set; }
        public bool PaymentDistributed { get; set; }
        public Vendor Owner { get; set; }
    }
}
