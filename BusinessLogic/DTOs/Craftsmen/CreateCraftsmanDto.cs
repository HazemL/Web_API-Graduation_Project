using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.Craftsmen
{
    // DTO مسئول عن إنشاء Craftsman جديد
    public class CreateCraftsmanDto
    {
        // الـ User المرتبط بالحرفي
        [Required]
        public int UserId { get; set; }

        // المهنة الأساسية
        [Required]
        public int ProfessionId { get; set; }

        // نبذة عن الحرفي
        [Required]
        [StringLength(1000)]
        public string Bio { get; set; } = null!;

        // عدد سنوات الخبرة
        [Range(0, 60)]
        public int ExperienceYears { get; set; }

        // أقل سعر
        [Range(0, double.MaxValue)]
        public decimal MinPrice { get; set; }

        // أعلى سعر
        [Range(0, double.MaxValue)]
        public decimal MaxPrice { get; set; }
    }
}
