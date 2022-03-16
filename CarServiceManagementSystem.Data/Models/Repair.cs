using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManagementSystem.Data.Models
{
    public class Repair
    {
        public Repair()
        {
            this.ChangedParts = new HashSet<Part>();
        }

        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int CarId { get; set; }

        public Car Car { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public string Description { get; set; }

        public int Odometer { get; set; }

        public Oil ChangedOil { get; set; }

        public int ChangedOilQuantity { get; set; }

        public ICollection<Part> ChangedParts { get; set; }
    }
}
