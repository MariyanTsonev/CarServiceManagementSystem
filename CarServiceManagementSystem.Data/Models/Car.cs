using CarServiceManagementSystem.Common;
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
    public class Car
    {
        public Car()
        {
            this.Options = new HashSet<CarOption>();
            this.Repairs = new HashSet<Repair>();
            this.Orders = new HashSet<Order>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(35, MinimumLength = 1, ErrorMessage = GlobalConstants.InvalidManufacturerLength)]
        public string Make { get; set; }

        [Required]
        [StringLength(70, MinimumLength = 1, ErrorMessage = GlobalConstants.InvalidVehicleModelLength)]
        public string Model { get; set; }

        [Required]
        public int EngineId { get; set; }

        public Engine Engine { get; set; }

        [Required]
        public FuelType FuelType { get; set; }

        [Range(1896, 2022, ErrorMessage = GlobalConstants.InvalidVehicleProductionYear)] // Create custom attribute
        public int Year { get; set; }

        [Range(1, 12, ErrorMessage = GlobalConstants.InvalidMonth)]
        public int Month { get; set; }

        [Required]
        [RegularExpression("[A-ZА-Я]{2}[0-9]{4}[A-ZА-Я]{2}", ErrorMessage = GlobalConstants.InvalidVehicleRegistrationPlate)]
        public string LicencePlate { get; set; }

        [MaxLength(200)]
        public string? Image { get; set; } 

        public string? UserId { get; set; }

        public ApplicationUser User { get; set; }

        [RegularExpression("[A-Z0-9]{17}", ErrorMessage = GlobalConstants.InvalidVinNumber)]
        public string? VinNumber { get; set; }

        [MaxLength(40)]
        public string? Colour { get; set; }

        [StringLength(650, ErrorMessage = "Vehicle description is too long!")]
        public string? Description { get; set; }

        public int? WarehouseId { get; set; }

        public CarWarehouse Warehouse { get; set; }

        [Precision(16, 2)]
        [Range(0, 1000000, ErrorMessage = "Price must be between 0 and 1,000,000 BGN!")]
        public decimal Price { get; set; }

        public ICollection<CarOption> Options { get; set; }

        public ICollection<Repair> Repairs { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
