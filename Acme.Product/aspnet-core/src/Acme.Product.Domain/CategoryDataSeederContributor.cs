using System;
using System.Threading.Tasks;
using Acme.Product.Brands;
using Acme.Product.Categories;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.Product;

public class CategoryDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Category, Guid> _categoryRepository;

    public CategoryDataSeederContributor(IRepository<Category, Guid> categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _categoryRepository.GetCountAsync() <= 0)
        {
            await _categoryRepository.InsertAsync(
                new Category
                {
                    Name = "Camera",
                    Thumbnail = "abc",
                    Slug = "category-nikon"
                },
                autoSave: true
            );

            await _categoryRepository.InsertAsync(
               new Category
               {
                   Name = "Lens - Ống kính",
                   Thumbnail = "xyz",
                   Slug = "category-lens"
               },
                autoSave: true
            );
            await _categoryRepository.InsertAsync(
               new Category
               {
                   Name = "Pin",
                   Thumbnail = "xyz",
                   Slug = "category-pin"
               },
                autoSave: true
            );
        }
    }
}
