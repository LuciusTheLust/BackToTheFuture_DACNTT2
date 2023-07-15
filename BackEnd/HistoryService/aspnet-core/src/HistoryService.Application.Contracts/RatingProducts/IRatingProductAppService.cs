using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.HistoryService.RatingProducts;

public interface IRatingProductAppService :
    ICrudAppService< //Defines CRUD methods
        RatingProductDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateRatingProductDto> //Used to create/update a book
{

}
