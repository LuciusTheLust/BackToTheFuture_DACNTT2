

using System;
using Volo.Abp.Application.Dtos;

namespace Acme.Product.Brands;

public class BrandDto : AuditedEntityDto<Guid>
{
    public string Name { get; set; }

    public string Thumbnail { get; set; }

    public string Slug { get; set; }
}

