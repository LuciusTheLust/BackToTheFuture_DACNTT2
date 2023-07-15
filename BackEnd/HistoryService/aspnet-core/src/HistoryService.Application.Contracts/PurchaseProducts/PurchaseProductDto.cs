using System;
using Volo.Abp.Application.Dtos;

namespace Acme.HistoryService.PurchaseProducts;

public class PurchaseProductDto : AuditedEntityDto<Guid>
{
    public string ProductId { get; set; }

    public PurchaseProductType Type { get; set; }

    public int Quantity { get; set; }
}
