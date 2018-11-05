using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SupplierTable
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierTelephone { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierEmail { get; set; }
    }
}
