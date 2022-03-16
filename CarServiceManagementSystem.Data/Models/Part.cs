using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManagementSystem.Data.Models
{
    public class Part
    {
        public int Id { get; set; }

        public string PartNumber { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Image { get; set; } // TODO

        public string Manufacturer { get; set; }

        public int CategoryId { get; set; }

        public PartCategory Category { get; set; }
    }
}
