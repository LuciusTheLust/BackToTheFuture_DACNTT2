using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.Product.Categories;

public class CreateUpdateCategoryDto
{
    [Required]
    [StringLength(128)]
    public string Name { get; set; }

    [Required]
    public string Thumbnail { get; set; }

    [Required]
    public string Slug { get; set; }
}
