using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Models
{
    class DataArrayApiResponse<T> : BaseApiResponse
    {
        public T[] data { get; set; }
    }
}
