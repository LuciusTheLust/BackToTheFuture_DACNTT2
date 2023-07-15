using Acme.PaymentService.Payments;
using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.PaymentService.Payments;

public class Payment : AuditedAggregateRoot<Guid>
{
    public string Balance { get; set; }

    public string Name  { get; set; }

    public PaymentType type { get; set; }

    public string UserId { get; set; }
}
