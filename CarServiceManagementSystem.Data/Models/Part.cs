using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManagementSystem.Data.Models
{
    public class Part
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40, ErrorMessage = "Part number is too long, should be no more than 40 characters!")]
        public string PartNumber { get; set; }

        [Required]
        [MaxLength(75, ErrorMessage = "Part name is too long, should be no more than 75 characters!")]
        public string Name { get; set; }

        [Precision(16, 2)]
        [Range(0, 3000, ErrorMessage = "Price must be in between 0 and 3000!")]
        public decimal Price { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Quantity must be a positive number!")]
        public int Quantity { get; set; }

        [Required]
        [StringLength(35, MinimumLength = 1, ErrorMessage = "Manufacturer name must be between 1 and 35 characters!")]
        public string Make { get; set; }

        [Required]
        [StringLength(70, MinimumLength = 1, ErrorMessage = "Vehicle model must be between 1 and 70 characters!")]
        public string Model { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; } // Implement validation for start date not to be after end date

        [Required]
        [MaxLength(200)]
        public string Image { get; set; } 

        [Required]
        [StringLength(35, MinimumLength = 1, ErrorMessage = "Manufacturer name must be between 1 and 35 characters!")]
        public string Manufacturer { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public PartCategory Category { get; set; }
    }
}
