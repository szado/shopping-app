using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ShoppingApp.Models.Database
{
    [Table("Stock")]
    class Stock
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int RemoteItemId { get; set; }
        public int Quantity { get; set; }
    }
}
