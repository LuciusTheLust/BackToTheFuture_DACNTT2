
using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.Product.ProductImages;

public class CreateUpdateProductImageDto
{
    [Required]
    public string ProductId { get; set; }
    [Required]
    public string Image { get; set; }
}
