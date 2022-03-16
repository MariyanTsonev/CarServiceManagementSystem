using CarServiceManagementSystem.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManagementSystem.Data.Models
{
    public class Oil
    {
        public int Id { get; set; }

        public string OilBrand { get; set; }

        public OilType Type { get; set; }

        public string Viscosity { get; set; }

        public decimal PricePerLiter { get; set; }

        public double Quantity { get; set; }
    }
}
