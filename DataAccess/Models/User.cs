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
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public string FullName { get; set; }
        public string Phone { get; set; }
        public string ProfileImage { get; set; }
        public string Role { get; set; } // "Admin", "Customer", "Craftsman"
        public bool IsActive { get; set; }
       

        
        public virtual ICollection<Craftsman>? CraftsmenProfiles { get; set; }
        public virtual ICollection<Review>? ReviewsWritten { get; set; }
        public virtual ICollection<Report>? ReportsFiled { get; set; }
    }
}
