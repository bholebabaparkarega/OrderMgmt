using System;
using System.Collections.Generic;
using System.Text;

namespace Order.CoreDAL.EntityLayer
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Email { get; set; }
        public string SpecialInstructions { get; set; }
        public string Phone { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
