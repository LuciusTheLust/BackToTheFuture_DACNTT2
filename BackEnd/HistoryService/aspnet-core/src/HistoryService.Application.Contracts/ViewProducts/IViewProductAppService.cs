using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.HistoryService.ViewProducts;

public interface IViewProductAppService :
    ICrudAppService< //Defines CRUD methods
        ViewProductDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateViewProductDto> //Used to create/update a book
{

}
