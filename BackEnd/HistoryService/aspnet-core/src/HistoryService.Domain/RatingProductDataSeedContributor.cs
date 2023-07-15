using System;
using System.Threading.Tasks;
using Acme.HistoryService.RatingProducts;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.HistoryService;

public class RatingProductDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<RatingProduct, Guid> _RatingProductRepository;

    public RatingProductDataSeederContributor(IRepository<RatingProduct, Guid> RatingProductRepository)
    {
        _RatingProductRepository = RatingProductRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _RatingProductRepository.GetCountAsync() <= 0)
        {
            await _RatingProductRepository.InsertAsync(
                new RatingProduct
                {
                    Content = "kksa",
                    ProductId = "akdj",
                    Star = "12",
                    type = RatingProductType.RatedByStar
                },
                autoSave: true
            );

            await _RatingProductRepository.InsertAsync(
                new RatingProduct
                {
                    Content = "llla",
                    ProductId = "ascg",
                    Star = "456",
                    type = RatingProductType.NumericalRating
                },
                autoSave: true
            );
        }
    }
}
