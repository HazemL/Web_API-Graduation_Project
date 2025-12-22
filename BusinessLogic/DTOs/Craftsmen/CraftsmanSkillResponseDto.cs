using DataAccess.Enums;

public class CraftsmanSkillResponseDto
{
    public int SkillId { get; set; }
    public string SkillName { get; set; } = null!;
    public ProficiencyLevel ProficiencyLevel { get; set; }
}
