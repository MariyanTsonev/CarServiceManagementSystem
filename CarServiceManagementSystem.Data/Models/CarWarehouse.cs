using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManagementSystem.Data.Models
{
    public class CarWarehouse
    {
        public CarWarehouse()
        {
            this.Cars = new HashSet<Car>();
        }

        public int Id { get; set; }

        [MaxLength(35, ErrorMessage = "Warehouse name must be no longer than 35 characters!")]
        public string Name { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
