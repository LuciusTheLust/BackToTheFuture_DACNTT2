
using System;
using Volo.Abp.Application.Dtos;

namespace Acme.Product.ProductImages;

public class ProductImageDto : AuditedEntityDto<Guid>
{
    public string ProductId { get; set; }
    public string Image { get; set; }
}
