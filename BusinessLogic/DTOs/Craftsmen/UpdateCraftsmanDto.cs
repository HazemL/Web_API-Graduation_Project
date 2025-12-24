using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.Craftsmen
{
    // DTO لتعديل بيانات الحرفي
    public class UpdateCraftsmanDto
    {
        [Required]
        [StringLength(1000)]
        public string Bio { get; set; } = null!;

        [Range(0, 60)]
        public int ExperienceYears { get; set; }

        [Range(0, double.MaxValue)]
        public decimal MinPrice { get; set; }

        [Range(0, double.MaxValue)]
        public decimal MaxPrice { get; set; }
    }
}
