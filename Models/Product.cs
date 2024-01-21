using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Core.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Product Name is required.")]
        public string ProductName { get; set; }

        [StringLength(100, ErrorMessage = "Product Description cannot exceed 100 characters.")]
        public string ProductDescription { get; set; }
    }
}