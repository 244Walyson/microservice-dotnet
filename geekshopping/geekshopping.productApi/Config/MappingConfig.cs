using AutoMapper;
using geekshopping.productApi.Data.DTO;
using geekshopping.productApi.model;

namespace geekshopping.productApi.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(Config =>
            {
                Config.CreateMap<ProductDTO, Product>();
                Config.CreateMap<Product, ProductDTO>(); 
            });
            return mappingConfig;
        }
    }
}
