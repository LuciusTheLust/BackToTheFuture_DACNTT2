using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.HistoryService.PurchaseProducts;

public interface IPurchaseProductAppService :
    ICrudAppService< //Defines CRUD methods
        PurchaseProductDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdatePurchaseProductDto> //Used to create/update a book
{

}
