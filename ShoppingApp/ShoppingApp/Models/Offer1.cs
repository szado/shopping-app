using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Models
{
    public class Offer
    {
        public int id { get; set; }
        public int customer_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string price { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public Dictionary<string, string> customer { get; set; }
        public Dictionary<string, string> category { get; set; }
    }
}
