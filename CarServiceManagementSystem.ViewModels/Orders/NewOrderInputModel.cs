using CarServiceManagementSystem.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManagementSystem.ViewModels.Orders
{
    public class NewOrderInputModel
    {
        public DateTime Date { get; set; }

        public string IssueDescription { get; set; }

        public string PhoneNumber { get; set; }

        public string CarMake { get; set; }

        public string CarModel { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public string LicencePlate { get; set; }

        public string VinNumber { get; set; }
        
        public FuelType FuelType { get; set; }

        public int Displacement { get; set; }

        public double HorsePower { get; set; }

        public string EngineCode { get; set; }

        public int CylindersCount { get; set; }
    }
}
