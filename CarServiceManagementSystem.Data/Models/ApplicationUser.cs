using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManagementSystem.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.Cars = new HashSet<Car>();
            this.ClientOrders = new HashSet<Order>();
            this.WorkOrders = new HashSet<Order>();
            this.Repairs = new HashSet<Repair>();
        }

        public ICollection<Car> Cars { get; set; }

        public ICollection<Order> ClientOrders { get; set; }

        public ICollection<Order> WorkOrders { get; set; }

        public ICollection<Repair> Repairs { get; set; }
    }
}
