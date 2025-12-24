using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.Skills
{
    // DTO لتعديل مهارة
    public class UpdateSkillDto
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; } = null!;

        [Required]
        [MinLength(3)]
        public string ArabicName { get; set; } = null!;
    }
}
