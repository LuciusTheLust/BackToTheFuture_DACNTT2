using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.OrderService.OrderProducts;

public interface IOrderProductAppService :
    ICrudAppService< //Defines CRUD methods
        OrderProductDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateOrderProductDto> //Used to create/update a book
{

}
