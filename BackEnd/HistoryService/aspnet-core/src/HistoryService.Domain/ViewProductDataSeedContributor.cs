using System;
using System.Threading.Tasks;
using Acme.HistoryService.ViewProducts;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.HistoryService;

public class ViewProductDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<ViewProduct, Guid> _ViewProductRepository;

    public ViewProductDataSeederContributor(IRepository<ViewProduct, Guid> ViewProductRepository)
    {
        _ViewProductRepository = ViewProductRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _ViewProductRepository.GetCountAsync() <= 0)
        {
            await _ViewProductRepository.InsertAsync(
                new ViewProduct
                {
                    ProductId = "lcmhd",
                    type = ViewProductType.Document
                },
                autoSave: true
            );

            await _ViewProductRepository.InsertAsync(
                new ViewProduct
                {
                    ProductId = "csaf",
                    type = ViewProductType.Image
                },
                autoSave: true
            );
        }
    }
}
