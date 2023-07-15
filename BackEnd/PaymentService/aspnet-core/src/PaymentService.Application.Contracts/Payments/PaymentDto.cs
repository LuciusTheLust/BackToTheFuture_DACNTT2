using Acme.PaymentService.Payments;
using System;
using Volo.Abp.Application.Dtos;

namespace PaymentService.Payments;

public class PaymentDto : AuditedEntityDto<Guid>
{
    public string Balance { get; set; }

    public string Name { get; set; }

    public PaymentType Type { get; set; }


    public string  UserId { get; set; }
}
