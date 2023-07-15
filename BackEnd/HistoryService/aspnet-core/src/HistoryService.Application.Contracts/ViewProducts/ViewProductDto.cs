using System;
using Volo.Abp.Application.Dtos;

namespace Acme.HistoryService.ViewProducts;

public class ViewProductDto : AuditedEntityDto<Guid>
{
    public string ProductId { get; set; }

    public ViewProductType type { get; set; }
}
