using CarServiceManagementSystem.Common;
using CarServiceManagementSystem.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManagementSystem.Data.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        [Required]
        [RegularExpression(@"(\+)?(359|0)8[789]\d{1}(|-| )\d{3}(|-| )\d{3}", ErrorMessage = GlobalConstants.InvalidPhoneNumber)]
        public string PhoneNumber { get; set; }

        public string? MechanicId { get; set; }

        public ApplicationUser? Mechanic { get; set; }

        [Required]
        public int CarId { get; set; }

        public Car Car { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = GlobalConstants.TooLongText)]
        public string IssueDescription { get; set; }

        public Status Status { get; set; }
    }
}
