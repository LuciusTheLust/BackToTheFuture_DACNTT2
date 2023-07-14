
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.Product.ProductImages;

public interface IProductImageAppService :
    ICrudAppService< //Defines CRUD methods
        ProductImageDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateProductImageDto> //Used to create/update a book
{

}
