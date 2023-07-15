using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.HistoryService.RatingProducts;

public class RatingProduct : AuditedAggregateRoot<Guid>
{
    public string Content { get; set; }

    public string ProductId { get; set; }

    public string Star { get; set; }

    public RatingProductType type { get; set; }

}
