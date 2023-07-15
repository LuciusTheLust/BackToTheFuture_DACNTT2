using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.OrderService.Orders;

public class CreateUpdateOrderDto
{
    [Required]
    public string Status { get; set; }

    [Required]
    public int Total { get; set; }

}
