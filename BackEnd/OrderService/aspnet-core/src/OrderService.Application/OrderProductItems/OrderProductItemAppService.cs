using Acme.OrderService.OrderProductItems;
using OrderService.OrderProductItems;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.OrderService.OrderProductItems;

public class OrderProductItemAppService :
    CrudAppService<
        OrderProductItem, //The Book entity
        OrderProductItemDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateOrderProductItemDto>, //Used to create/update a book
    IOrderProductItemAppService //implement the IBookAppService
{
    public OrderProductItemAppService(IRepository<OrderProductItem, Guid> repository)
        : base(repository)
    {

    }
}
