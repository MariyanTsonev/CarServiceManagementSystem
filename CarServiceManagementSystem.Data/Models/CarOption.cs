using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManagementSystem.Data.Models
{
    public class CarOption
    {
        public int CarId { get; set; }

        public Car Car { get; set; }

        public int OptionId { get; set; }

        public Option Option { get; set; }
    }
}
