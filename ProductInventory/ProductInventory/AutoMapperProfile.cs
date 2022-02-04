using AutoMapper;
using ProductInventory.Dtos.Product;
using ProductInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductInventory
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, GetProductdto>();
            CreateMap<AddProductdto, Product>();
            
        }
    }
}
