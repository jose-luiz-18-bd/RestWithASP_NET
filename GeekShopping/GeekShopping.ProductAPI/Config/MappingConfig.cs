using AutoMapper;

namespace GeekShopping.ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<Model.Product, Data.ValueObjects.ProductVO>();
                config.CreateMap< Data.ValueObjects.ProductVO, Model.Product>();
            });
            return mappingConfig;
        }
    }
}

