using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaRestoCashier
{
    public class OrderList
    {
        public String itemID { get; set; }
        public String name { get; set; }
        public int qty { get; set; }
        public double price { get; set; }
    }
}