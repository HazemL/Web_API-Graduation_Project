using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class User :BaseModel
    {
       

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        public string FullName { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string? ProfileImage { get; set; }
        [Required]
        public string Role { get; set; } = string.Empty;// "Admin", "Customer", "Craftsman"
        public bool IsActive { get; set; }
       

        
        public virtual ICollection<Craftsman>? CraftsmenProfiles { get; set; }
        public virtual ICollection<Review>? ReviewsWritten { get; set; }
        public virtual ICollection<Report>? ReportsFiled { get; set; }
    }
}
