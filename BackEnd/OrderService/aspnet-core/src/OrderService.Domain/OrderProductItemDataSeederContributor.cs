using System;
using System.Threading.Tasks;
using Acme.OrderService.OrderProductItems;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.OrderService;

public class OrderProductItemDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<OrderProductItem, Guid> _orderproductitemRepository;

    public OrderProductItemDataSeederContributor(IRepository<OrderProductItem, Guid> orderproductitemRepository)
    {
        _orderproductitemRepository = orderproductitemRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _orderproductitemRepository.GetCountAsync() <= 0)
        {
            await _orderproductitemRepository.InsertAsync(
                new OrderProductItem
                {
                    ProductId = "hjd",
                    Name = "Long",
                    Price = 10000,
                    Quantity = 5,
                    Thumbnail = "aaa",
                    Slug = "kkk"
                },
                autoSave: true
            );

            await _orderproductitemRepository.InsertAsync(
                new OrderProductItem
                {
                    ProductId = "oip",
                    Name = "Huyen",
                    Price = 5000,
                    Quantity = 10,
                    Thumbnail = "mmn",
                    Slug = "aad"
                },
                autoSave: true
            );
        }
    }
}
