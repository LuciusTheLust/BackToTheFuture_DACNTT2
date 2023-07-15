using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.HistoryService.PurchaseProducts;

public class PurchaseProductAppService :
    CrudAppService<
        PurchaseProduct, //The Book entity
        PurchaseProductDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdatePurchaseProductDto>, //Used to create/update a book
    IPurchaseProductAppService //implement the IBookAppService
{
    public PurchaseProductAppService(IRepository<PurchaseProduct, Guid> repository)
        : base(repository)
    {

    }
}
