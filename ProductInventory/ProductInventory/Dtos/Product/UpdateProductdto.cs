using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductInventory.Dtos.Product
{
    public class UpdateProductdto
    {
        public int id { get; set; } = 1;
        public string name { get; set; } = "Lux Soap";
        public string description { get; set; }
        public int price { get; set; }
    }
}
