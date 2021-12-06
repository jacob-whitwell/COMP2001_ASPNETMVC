using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication2.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
    }
}
