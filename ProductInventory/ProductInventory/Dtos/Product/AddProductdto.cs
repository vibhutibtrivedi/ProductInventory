using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductInventory.Dtos.Product
{
    public class AddProductdto
    {
        public string name { get; set; } 
        public string description { get; set; }
        public int price { get; set; }
    }
}
