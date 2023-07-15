using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.HistoryService.ViewProducts;

public class ViewProduct : AuditedAggregateRoot<Guid>
{

    public string ProductId { get; set; }

    public ViewProductType type { get; set; }

}
