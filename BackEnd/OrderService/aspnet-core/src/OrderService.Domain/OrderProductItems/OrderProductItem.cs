using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.OrderService.OrderProductItems;

public class OrderProductItem : AuditedAggregateRoot<Guid>
{
    public string ProductId { get; set; }

    public string Name { get; set; }

    public float Price { get; set; }

    public int Quantity { get; set; }

    public string Thumbnail { get; set; }

    public string Slug { get; set; }
}
