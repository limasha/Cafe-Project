using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CafeProject.Models
{
    public class ItemList
    {
        public int ID { get; set; }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime AddedDate { get; set; }
    }
}