using System;
using System.Threading.Tasks;
using Acme.HistoryService.PurchaseProducts;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.HistoryService;

public class PurchaseProductDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<PurchaseProduct, Guid> _PurchaseProductRepository;

    public PurchaseProductDataSeederContributor(IRepository<PurchaseProduct, Guid> PurchaseProductRepository)
    {
        _PurchaseProductRepository = PurchaseProductRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _PurchaseProductRepository.GetCountAsync() <= 0)
        {
            await _PurchaseProductRepository.InsertAsync(
                new PurchaseProduct
                {
                    ProductId = "ajj",
                    Type = PurchaseProductType.Centerled,
                    Quantity = 23
                },
                autoSave: true
            );

            await _PurchaseProductRepository.InsertAsync(
                 new PurchaseProduct
                 {
                     ProductId = "kkk",
                     Type = PurchaseProductType.Centralizedpurchasing,
                     Quantity = 25
                 },
                 autoSave: true
             );
        }
    }
}
