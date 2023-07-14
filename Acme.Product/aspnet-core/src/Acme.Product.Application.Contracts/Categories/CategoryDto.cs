

using System;
using Volo.Abp.Application.Dtos;

namespace Acme.Product.Categories;

public class CategoryDto : AuditedEntityDto<Guid>
{
    public string Name { get; set; }

    public string Thumbnail { get; set; }

    public string Slug { get; set; }
}

