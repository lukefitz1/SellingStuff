using AutoMapper;
using SellingStuff.Controllers.Resources;
using SellingStuff.Models;

namespace SellingStuff.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to API
            CreateMap<Product, ProductResource>();

            // API to Domain
            CreateMap<ProductResource, Product>();
        }
    }
}