using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.Product.ProductImages;

public class ProductImageAppService :
    CrudAppService<
        ProductImage, //The Book entity
        ProductImageDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateProductImageDto>, //Used to create/update a book
    IProductImageAppService //implement the IBookAppService
{
    public ProductImageAppService(IRepository<ProductImage, Guid> repository)
        : base(repository)
    {

    }
}
