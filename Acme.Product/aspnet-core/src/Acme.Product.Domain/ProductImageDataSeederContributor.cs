
using System;
using System.Threading.Tasks;
using Acme.Product.ProductImages;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.Product;

public class ProductImageDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<ProductImage, Guid> _productImageRepository;

    public ProductImageDataSeederContributor(IRepository<ProductImage, Guid> productImageRepository)
    {
        _productImageRepository = productImageRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _productImageRepository.GetCountAsync() <= 0)
        {
            await _productImageRepository.InsertAsync(
                new ProductImage
                {
                    ProductId = "abc",
                    Image = "xyz"
                },
                autoSave: true
            );

            await _productImageRepository.InsertAsync(
                new ProductImage
                {
                    ProductId = "xyz",
                    Image = "alo"
                },
                autoSave: true
            );
        }
    }
}
