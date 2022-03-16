using CarServiceManagementSystem.Data.Enums;
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

        public string Make { get; set; }

        public string Model { get; set; }

        public int EngineId { get; set; }

        public Engine Engine { get; set; }

        public FuelType FuelType { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public string LicencePlate { get; set; }

        public string Image { get; set; } // TO DO PROPERLY

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public string VinNumber { get; set; }

        public string Colour { get; set; }

        public string Description { get; set; }

        public int WarehouseId { get; set; }

        public CarWarehouse Warehouse { get; set; }

        public decimal Price { get; set; }

        public ICollection<CarOption> Options { get; set; }

        public ICollection<Repair> Repairs { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
