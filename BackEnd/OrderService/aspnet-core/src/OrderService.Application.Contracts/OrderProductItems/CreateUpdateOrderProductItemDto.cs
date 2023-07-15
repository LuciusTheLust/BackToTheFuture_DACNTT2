using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OrderService.OrderProductItems
{
    public class CreateUpdateOrderProductItemDto
    {
        [Required]
        public string ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string Thumbnail { get; set; }

        [Required]
        public string Slug { get; set; }
    }
}
