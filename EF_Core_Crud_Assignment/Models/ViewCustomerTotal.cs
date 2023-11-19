using System;
using System.Collections.Generic;

namespace EF_Core_Crud_Assignment.Models
{
    public partial class ViewCustomerTotal
    {
        public string CompanyName { get; set; } = null!;
        public string CustomerId { get; set; } = null!;
        public double? CustomerTotal { get; set; }
    }
}
