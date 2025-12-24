using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.Governorates
{
    public class AddGovernorateDto
    {
        [Required, StringLength(100)]
        public string Name { get; set; } = null!;

        [Required, StringLength(100)]
        public string ArabicName { get; set; } = null!;
    }
}
