﻿using System;
using System.Collections.Generic;

namespace EF_Core_Crud_Assignment.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}
