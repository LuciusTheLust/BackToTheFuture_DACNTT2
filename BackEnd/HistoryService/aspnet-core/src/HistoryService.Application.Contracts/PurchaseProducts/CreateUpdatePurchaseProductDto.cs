using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.HistoryService.PurchaseProducts;

public class CreateUpdatePurchaseProductDto
{
    [Required]
    public string ProductId { get; set; }

    [Required]
    public PurchaseProductType Type { get; set; }

    [Required]
    public int Quantity { get; set; }

}
