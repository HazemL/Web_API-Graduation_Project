namespace BusinessLogic.DTOs.Craftsmen
{
    // DTO للـ Response
    public class GetCraftsmanDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public string FullName { get; set; } = string.Empty;
        public string? GovernorateName { get; set; }
        public string? CityName { get; set; }

        public int ProfessionId { get; set; }

        public string Bio { get; set; } = string.Empty;
        public int ExperienceYears { get; set; }

        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }

        public bool IsVerified { get; set; }
        public DateTime? VerificationDate { get; set; }
    }

}
