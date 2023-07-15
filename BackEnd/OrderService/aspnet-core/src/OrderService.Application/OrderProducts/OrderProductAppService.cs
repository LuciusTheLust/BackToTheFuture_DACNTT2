using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.OrderService.OrderProducts;

public class OrderProductAppService :
    CrudAppService<
        OrderProduct, //The Book entity
        OrderProductDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateOrderProductDto>, //Used to create/update a book
    IOrderProductAppService //implement the IBookAppService
{
    public OrderProductAppService(IRepository<OrderProduct, Guid> repository)
        : base(repository)
    {

    }
}
