using AutoMapper;
using Acme.Product.Brands;

namespace Acme.Product;

public class ProductApplicationAutoMapperProfile : Profile
{
    public ProductApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Brand, BrandDto>();
        CreateMap<CreateUpdateBrandDto, Brand>();
    }
}
