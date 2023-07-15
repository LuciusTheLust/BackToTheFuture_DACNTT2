using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.OrderService.Orders;

public class Order : AuditedAggregateRoot<Guid>
{
    public string Status { get; set; }

    public int Total { get; set; }

}
