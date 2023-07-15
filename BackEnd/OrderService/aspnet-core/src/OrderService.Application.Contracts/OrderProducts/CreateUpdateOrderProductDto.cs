using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.OrderService.OrderProducts;

public class CreateUpdateOrderProductDto
{
    [Required]
    public string OrderId { get; set; }

    [Required]
    public string ProductId { get; set; }

}
