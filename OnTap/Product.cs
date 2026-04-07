using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapLop
{
    public class Product
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }

        public String Category { get; set; }
        public required List<OrderDetail> Details { get; set; }
    }
}
