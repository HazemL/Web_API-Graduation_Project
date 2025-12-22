using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.Subscriptions
{
    public class CreateSubscriptionDto
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid PlanId")]
        public int PlanId { get; set; }
    }
}
