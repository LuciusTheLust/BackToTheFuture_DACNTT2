using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.PaymentService.Payments;

public class CreateUpdatePaymentDto
{
    [Required]
    public string Balance { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public PaymentType Type { get; set; } = PaymentType.cash;

    [Required]
    public string UserId { get; set; }
}
