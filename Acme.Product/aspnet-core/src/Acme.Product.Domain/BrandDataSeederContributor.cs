using System;
using System.Threading.Tasks;
using Acme.Product.Brands;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore;

public class BrandDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Brand, Guid> _brandRepository;

    public BrandDataSeederContributor(IRepository<Brand, Guid> brandRepository)
    {
        _brandRepository = brandRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _brandRepository.GetCountAsync() <= 0)
        {
            await _brandRepository.InsertAsync(
                new Brand
                {
                    Name = "Nikon",
                    Thumbnail = "abc",
                    Slug = "brand-nikon"
                },
                autoSave: true
            );

            await _brandRepository.InsertAsync(
               new Brand
               {
                   Name = "Sony",
                   Thumbnail = "xyz",
                   Slug = "brand-sony"
               },
                autoSave: true
            );
            await _brandRepository.InsertAsync(
               new Brand
               {
                   Name = "Olympus",
                   Thumbnail = "xyz",
                   Slug = "brand-olympus"
               },
                autoSave: true
            );
        }
    }
}
