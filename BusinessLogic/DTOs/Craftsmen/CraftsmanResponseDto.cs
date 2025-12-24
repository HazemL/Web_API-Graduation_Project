namespace BusinessLogic.DTOs.Craftsmen
{
    public class CraftsmanResponseDto
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int ProfessionId { get; set; }

        public string Bio { get; set; } = null!;
        public int ExperienceYears { get; set; }

        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }

        public bool IsVerified { get; set; }
        public DateTime? VerificationDate { get; set; }
    }
}
