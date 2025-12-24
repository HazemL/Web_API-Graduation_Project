using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.Reports
{
    // إنشاء بلاغ
    public class AddReportDto
    {
        [Required]
        public int CraftsmanId { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 1)]
        public string Message { get; set; }
    }
}
