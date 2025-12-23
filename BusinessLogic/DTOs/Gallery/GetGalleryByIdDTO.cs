namespace BusinessLogic.DTOs
{
    public class GetGalleryByIdDTO
    {
        public int Id { get; set; }
        public int CraftsmanId { get; set; }
        public string MediaUrl { get; set; }
        public string MediaType { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}