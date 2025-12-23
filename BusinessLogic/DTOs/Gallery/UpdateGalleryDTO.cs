using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs
{
    public class UpdateGalleryDTO
    {
        [Required]
        public string MediaUrl { get; set; }

        [Required]
        public string MediaType { get; set; }

        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}