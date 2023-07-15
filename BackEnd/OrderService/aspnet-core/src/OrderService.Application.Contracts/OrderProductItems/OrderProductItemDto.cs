using System;
using Volo.Abp.Application.Dtos;

namespace Acme.OrderService.OrderProductItems;

public class OrderProductItemDto : AuditedEntityDto<Guid>
{
    public string ProductId { get; set; }

    public string Name { get; set; }

    public float Price { get; set; }

    public int Quantity { get; set; }

    public string Thumbnail { get; set; }

    public string Slug { get; set; }
}
