using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        //TODO date validation
        public DateTime Date { get; set; }

        [Required]
        public int CarId { get; set; }

        public Car Car { get; set; }

        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        [Required]
        [StringLength(650, ErrorMessage = "Repair description is too long!")]
        public string Description { get; set; }

        [Range(1, 999999, ErrorMessage = "Odometer reading must be between 1 and 999999!")]
        public int Odometer { get; set; }

        public Oil ChangedOil { get; set; }

        public int ChangedOilQuantity { get; set; }

        public ICollection<Part> ChangedParts { get; set; }
    }
}
