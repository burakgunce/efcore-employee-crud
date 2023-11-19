using System;
using System.Collections.Generic;

namespace EF_Core_Crud_Assignment.Models
{
    public partial class ViewEmployeeManager
    {
        public string FullName { get; set; } = null!;
        public string Manager { get; set; } = null!;
    }
}
