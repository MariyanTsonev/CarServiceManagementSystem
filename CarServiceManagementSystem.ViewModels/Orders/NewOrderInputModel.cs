using CarServiceManagementSystem.Common;
using CarServiceManagementSystem.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManagementSystem.ViewModels.Orders
{
    public class NewOrderInputModel
    {
        public DateTime Date { get; set; } //add validation for future date to be chosable only.

        [Required]
        [MaxLength(500, ErrorMessage = GlobalConstants.TooLongText)]
        public string IssueDescription { get; set; }

        [Required]
        [RegularExpression(@"(\+)?(359|0)8[789]\d{1}(|-| )\d{3}(|-| )\d{3}", ErrorMessage = GlobalConstants.InvalidPhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(35, MinimumLength = 1, ErrorMessage = GlobalConstants.InvalidManufacturerLength)]
        public string CarMake { get; set; }

        [Required]
        [StringLength(70, MinimumLength = 1, ErrorMessage = GlobalConstants.InvalidVehicleModelLength)]
        public string CarModel { get; set; }

        [Range(1896, 2022, ErrorMessage = GlobalConstants.InvalidVehicleProductionYear)] // Create custom attribute
        public int Year { get; set; }

        [Range(1, 12, ErrorMessage = GlobalConstants.InvalidMonth)]
        public int Month { get; set; }

        [Range(1, 999999, ErrorMessage = GlobalConstants.InvalidOdometerReading)]
        public int Odometer { get; set; }

        [Required]
        [RegularExpression("[A-ZА-Я]{2}[0-9]{4}[A-ZА-Я]{2}", ErrorMessage = GlobalConstants.InvalidVehicleRegistrationPlate)]
        public string LicencePlate { get; set; }

        [RegularExpression("[A-Z0-9]{17}", ErrorMessage = GlobalConstants.InvalidVinNumber)]
        public string VinNumber { get; set; }
        
        [Required]
        public FuelType FuelType { get; set; }

        [Range(40, 9300, ErrorMessage = GlobalConstants.InvalidEngineDisplacement)]
        public int Displacement { get; set; }

        [Range(0.1, 850, ErrorMessage = GlobalConstants.InvalidEngineHorsePower)]
        public double HorsePower { get; set; }

        [MaxLength(25, ErrorMessage = GlobalConstants.InvalidEngineCode)]
        public string EngineCode { get; set; }

        [Range(1, 16, ErrorMessage = GlobalConstants.InvalidEngineCylinderCount)] // Can create custom attribute to exlucde 7,9,11,13,14,15 cylinder count
        public int CylindersCount { get; set; }
    }
}
