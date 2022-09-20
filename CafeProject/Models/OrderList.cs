using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CafeProject.Models
{
    public class OrderList
    {
        public int OID { get; set; }
        public string OrderId { get; set; }
        public string ItemName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Qty { get; set; }
        public decimal Total { get; set; }
    }
}