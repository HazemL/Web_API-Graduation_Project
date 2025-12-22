using DataAccess.Enums;
using System.ComponentModel.DataAnnotations;

public class UpdateCraftsmanSkillDto
{
    [Required]
    [EnumDataType(typeof(ProficiencyLevel))]
    public ProficiencyLevel ProficiencyLevel { get; set; }
}
