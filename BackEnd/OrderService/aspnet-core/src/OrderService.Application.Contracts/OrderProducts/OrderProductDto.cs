using System;
using Volo.Abp.Application.Dtos;

namespace Acme.OrderService.OrderProducts;

public class OrderProductDto : AuditedEntityDto<Guid>
{
    public string OrderId { get; set; }

    public string ProductId { get; set; }

}
