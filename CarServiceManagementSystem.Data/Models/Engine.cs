using CarServiceManagementSystem.Common;
using CarServiceManagementSystem.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManagementSystem.Data.Models
{
    public class Engine
    {
        public Engine()
        {
            this.Cars = new HashSet<Car>();
        }

        public int Id { get; set; }

        [Range(40, 9300, ErrorMessage = GlobalConstants.InvalidEngineDisplacement)]
        public int Displacement { get; set; }

        [Range(0.1, 850, ErrorMessage = GlobalConstants.InvalidEngineHorsePower)]
        public double HorsePower { get; set; }

        [MaxLength(25, ErrorMessage = GlobalConstants.InvalidEngineCode)]
        public string? EngineCode { get; set; }

        [Range(1, 16, ErrorMessage = GlobalConstants.InvalidEngineCylinderCount)] // Can create custom attribute to exlucde 7,9,11,13,14,15 cylinder count
        public int CylindersCount { get; set; }

        [Range(0, 1100, ErrorMessage = "Engine Torque must be a positive number, no higher than 1100!")]
        public double Torque { get; set; }

        [Required]
        public FuelType FuelType { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
