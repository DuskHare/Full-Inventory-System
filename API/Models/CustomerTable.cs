using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class CustomerTable
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerTelephone { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerEmail { get; set; }
    }
}
