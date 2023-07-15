using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.HistoryService.RatingProducts;

public class CreateUpdateRatingProductDto
{
    [Required]
    public string Content { get; set; }

    [Required]
    public string ProductId { get; set; }

    [Required]
    public string Star { get; set; }

    [Required]
    public RatingProductType type { get; set; }

}
