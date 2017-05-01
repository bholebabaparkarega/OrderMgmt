using System;
using System.Collections.Generic;
using System.Text;

namespace Order.CoreDAL.EntityLayer
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public int ItemCount { get; set; }
        public double TotalItemCost { get; set; }
    }
}
