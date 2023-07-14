using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.Product.Brands;

public interface IBrandAppService :
    ICrudAppService< //Defines CRUD methods
        BrandDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBrandDto> //Used to create/update a book
{

}
