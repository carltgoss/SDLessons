using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _12_General_Store.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProductName {get; set; }
        [Required]
        public int UPC { get; set; }
        [Required]
        [Range(0, 1000)]
        public decimal price { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}