using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.Users
{
    public class UpdateUserDto
    {
        [Required]
        public string FullName { get; set; } = null!;

        public string? Phone { get; set; }
        public string? ProfileImage { get; set; }

        [Required]
        public string Role { get; set; } = null!;

        public bool IsActive { get; set; }
    }
}
