using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.Product.ProductImages;

public class ProductImage : AuditedAggregateRoot<Guid>
{
    public string ProductId { get; set; }
    public string Image { get; set; }

}
