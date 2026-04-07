using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapLop
{
    public class Order
    {
        public String Id { get; set; }
        public String CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderDetail> Details { get; set; };
    }
}
