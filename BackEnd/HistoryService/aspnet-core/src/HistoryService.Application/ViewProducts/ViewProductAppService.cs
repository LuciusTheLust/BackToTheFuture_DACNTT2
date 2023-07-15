using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.HistoryService.ViewProducts;

public class ViewProductAppService :
    CrudAppService<
        ViewProduct, //The Book entity
        ViewProductDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateViewProductDto>, //Used to create/update a book
    IViewProductAppService //implement the IBookAppService
{
    public ViewProductAppService(IRepository<ViewProduct, Guid> repository)
        : base(repository)
    {

    }
}
