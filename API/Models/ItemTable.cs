using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ItemTable
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public double ItemPrice { get; set; }
    }
}
