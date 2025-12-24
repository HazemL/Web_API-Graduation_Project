namespace BusinessLogic.DTOs.Professions
{
    // DTO للـ GET
    public class ProfessionResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string? Description { get; set; }
    }
}
