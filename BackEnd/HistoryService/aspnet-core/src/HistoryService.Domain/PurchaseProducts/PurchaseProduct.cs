using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.HistoryService.PurchaseProducts;

public class PurchaseProduct : AuditedAggregateRoot<Guid>
{
    public string ProductId { get; set; }

    public PurchaseProductType Type { get; set; }

    public int Quantity { get; set; }

}
