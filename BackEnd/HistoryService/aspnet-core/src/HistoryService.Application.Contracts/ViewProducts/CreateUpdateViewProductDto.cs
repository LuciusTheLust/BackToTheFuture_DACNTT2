using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.HistoryService.ViewProducts;

public class CreateUpdateViewProductDto
{
    [Required]
    public string ProductId { get; set; }

    [Required]
    public ViewProductType type { get; set; }
}
