using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.Product.Brands;

public class Brand : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }

    public string Thumbnail { get; set; }

    public string Slug { get; set; }
}
