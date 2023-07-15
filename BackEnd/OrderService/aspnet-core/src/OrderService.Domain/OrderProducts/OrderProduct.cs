using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.OrderService.OrderProducts;

public class OrderProduct : AuditedAggregateRoot<Guid>
{
    public string OrderId { get; set; }

    public string ProductId { get; set; }

}
