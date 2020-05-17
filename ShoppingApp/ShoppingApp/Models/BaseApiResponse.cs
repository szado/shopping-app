using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Models
{
    class BaseApiResponse
    {
        public int code { get; set; }
        public bool success { get; set; }
        public string[] errors { get; set; }
    }
}
