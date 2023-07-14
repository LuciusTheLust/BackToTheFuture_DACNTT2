using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.Product.Brands;

public class BrandAppService :
    CrudAppService<
        Brand, //The Book entity
        BrandDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBrandDto>, //Used to create/update a book
    IBrandAppService //implement the IBookAppService
{
    public BrandAppService(IRepository<Brand, Guid> repository)
        : base(repository)
    {

    }
}
