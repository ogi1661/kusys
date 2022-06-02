using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProje.API.DTOs;
using TestProje.Core.Models;

namespace TestProje.API.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();

            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
        }
       

            
    }
}
