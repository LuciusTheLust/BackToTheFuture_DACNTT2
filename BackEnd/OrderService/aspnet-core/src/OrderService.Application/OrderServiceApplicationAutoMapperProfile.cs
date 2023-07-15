using Acme.OrderService.OrderProductItems;
using Acme.OrderService.OrderProducts;
using Acme.OrderService.Orders;
using AutoMapper;
using OrderService.OrderProductItems;

namespace OrderService;

public class OrderServiceApplicationAutoMapperProfile : Profile
{
    public OrderServiceApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<OrderProductItem, OrderProductItemDto>();
        CreateMap<CreateUpdateOrderProductItemDto, OrderProductItem>();
        CreateMap<OrderProduct, OrderProductDto>();
        CreateMap<CreateUpdateOrderProductDto, OrderProduct>();
        CreateMap<Order, OrderDto>();
        CreateMap<CreateUpdateOrderDto, Order>();
    }
}
