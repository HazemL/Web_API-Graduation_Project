using DataAccess.Enums;
using System.ComponentModel.DataAnnotations;

public class CreateCraftsmanSkillDto
{
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "SkillId must be greater than 0")]
    public int SkillId { get; set; }

    [Required]
    [EnumDataType(typeof(ProficiencyLevel))]
    public ProficiencyLevel ProficiencyLevel { get; set; }
}
