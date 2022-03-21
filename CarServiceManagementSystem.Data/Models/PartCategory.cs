using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManagementSystem.Data.Models
{
    public class PartCategory
    {
        public PartCategory()
        {
            this.Parts = new HashSet<Part>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Name is too long, must be no more than 100 characters!")]
        public string Name { get; set; }

        public ICollection<Part> Parts { get; set; }
    }
}
