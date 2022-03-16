using CarServiceManagementSystem.Data.Enums;
using System;
using System.Collections.Generic;
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

        public int Displacement { get; set; }

        public double Power { get; set; }

        public string EngineCode { get; set; }

        public int CylindersCount { get; set; }

        public double Torque { get; set; }

        public FuelType FuelType { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
