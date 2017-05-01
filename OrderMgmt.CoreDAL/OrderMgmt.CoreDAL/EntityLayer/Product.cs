using System;
using System.Collections.Generic;
using System.Text;

namespace Order.CoreDAL.EntityLayer
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public double UnitPrice { get; set; }
    }
}
