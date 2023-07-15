using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Acme.OrderService.Orders;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.OrderService;

public class OrderDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Order, Guid> _orderRepository;

    public OrderDataSeederContributor(IRepository<Order, Guid> orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _orderRepository.GetCountAsync() <= 0)
        {
            await _orderRepository.InsertAsync(
                new Order
                {
                    Status = "abcd",
                    Total = 20
                },
                autoSave: true
            );

            await _orderRepository.InsertAsync(
                new Order
                {
                    Status = "cdef",
                    Total = 30
                },
                autoSave: true
            );
        }
    }
}
