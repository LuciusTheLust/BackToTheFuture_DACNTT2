using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.HistoryService.RatingProducts;

public class RatingProductAppService :
    CrudAppService<
        RatingProduct, //The Book entity
        RatingProductDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateRatingProductDto>, //Used to create/update a book
    IRatingProductAppService //implement the IBookAppService
{
    public RatingProductAppService(IRepository<RatingProduct, Guid> repository)
        : base(repository)
    {

    }
}
