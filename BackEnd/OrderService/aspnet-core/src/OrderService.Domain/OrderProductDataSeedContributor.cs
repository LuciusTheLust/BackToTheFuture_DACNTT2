using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Acme.OrderService.OrderProducts;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.OrderService;

public class OrderProductDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<OrderProduct, Guid> _orderproductRepository;

    public OrderProductDataSeederContributor(IRepository<OrderProduct, Guid> orderproductRepository)
    {
        _orderproductRepository = orderproductRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _orderproductRepository.GetCountAsync() <= 0)
        {
            await _orderproductRepository.InsertAsync(
                new OrderProduct
                {
                    OrderId = "jjk",
                    ProductId = "hjd"
                },
                autoSave: true
            );

            await _orderproductRepository.InsertAsync(
                new OrderProduct
                {
                    OrderId = "kkk",
                    ProductId = "las"
                },
                autoSave: true
            );
        }
    }
}
