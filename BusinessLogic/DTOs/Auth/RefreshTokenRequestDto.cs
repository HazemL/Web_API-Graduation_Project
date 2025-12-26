using System.ComponentModel.DataAnnotations;

public class RefreshTokenRequestDto
{
    [Required]
    public string RefreshToken { get; set; }
}
