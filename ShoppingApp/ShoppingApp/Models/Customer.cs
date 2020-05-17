using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string nickname { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
}
