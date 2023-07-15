using OrderService.OrderProductItems;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.OrderService.OrderProductItems;

public interface IOrderProductItemAppService :
    ICrudAppService< //Defines CRUD methods
        OrderProductItemDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateOrderProductItemDto> //Used to create/update a book
{

}
