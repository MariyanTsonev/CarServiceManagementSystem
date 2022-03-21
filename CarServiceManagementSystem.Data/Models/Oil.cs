using CarServiceManagementSystem.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManagementSystem.Data.Models
{
    public class Oil
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "Oil Brand must not exceed 60 characters!")]
        public string OilBrand { get; set; }

        [Required]
        public OilType Type { get; set; }

        [Required]
        [RegularExpression("[0-9]+W-[0-9]{2}", ErrorMessage = "Oil Viscosity must be in the following format: XXW-XX! Example: 5W-40")]
        public string Viscosity { get; set; }

        [Precision(16, 2)]
        [Range(0, 80, ErrorMessage = "Price per leter must be between 0 and 80!")]
        public decimal PricePerLiter { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Quantity must be a positive number!")]
        public double Quantity { get; set; }
    }
}
