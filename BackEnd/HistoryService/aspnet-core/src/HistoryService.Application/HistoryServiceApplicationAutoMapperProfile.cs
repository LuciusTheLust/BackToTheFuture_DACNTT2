using Acme.HistoryService.PurchaseProducts;
using Acme.HistoryService.RatingProducts;
using Acme.HistoryService.ViewProducts;
using AutoMapper;

namespace HistoryService;

public class HistoryServiceApplicationAutoMapperProfile : Profile
{
    public HistoryServiceApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<PurchaseProduct, PurchaseProductDto>();
        CreateMap<CreateUpdatePurchaseProductDto, PurchaseProduct>();
        CreateMap<RatingProduct, RatingProductDto>();
        CreateMap<CreateUpdateRatingProductDto, RatingProduct>();
        CreateMap<ViewProduct,  ViewProductDto>();
        CreateMap<CreateUpdateViewProductDto, ViewProductDto>();
    }
}
