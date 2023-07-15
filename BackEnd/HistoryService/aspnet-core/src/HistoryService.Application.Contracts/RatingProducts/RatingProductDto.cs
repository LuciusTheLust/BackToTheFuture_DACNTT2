using System;
using Volo.Abp.Application.Dtos;

namespace Acme.HistoryService.RatingProducts;

public class RatingProductDto : AuditedEntityDto<Guid>
{
    public string Content { get; set; }

    public string ProductId { get; set; }

    public string Star { get; set; }

    public RatingProductType type { get; set; }
}
