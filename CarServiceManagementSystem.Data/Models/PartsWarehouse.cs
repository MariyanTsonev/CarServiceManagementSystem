using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManagementSystem.Data.Models
{
    public class PartsWarehouse
    {
        public PartsWarehouse()
        {
            this.Parts = new HashSet<Part>();
            this.Oils = new HashSet<Oil>();
        }

        public int Id { get; set; }

        public ICollection<Part> Parts { get; set; }

        public ICollection<Oil> Oils { get; set; }
    }
}
