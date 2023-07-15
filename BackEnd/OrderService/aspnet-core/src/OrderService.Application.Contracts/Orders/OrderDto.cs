using System;
using Volo.Abp.Application.Dtos;

namespace Acme.OrderService.Orders;

public class OrderDto : AuditedEntityDto<Guid>
{
    public string Status { get; set; }

    public int Total { get; set; }

}
