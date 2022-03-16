using CarServiceManagementSystem.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManagementSystem.Data.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public string PhoneNumber { get; set; }

        public string MechanicId { get; set; }

        public ApplicationUser Mechanic { get; set; }

        public int CarId { get; set; }

        public Car Car { get; set; }

        public string IssueDescription { get; set; }

        public Status Status { get; set; }
    }
}
