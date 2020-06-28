using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ShoppingApp.Models.Database
{
    [Table("Cart")]
    public class Cart
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int RemoteItemId { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
    }
}
