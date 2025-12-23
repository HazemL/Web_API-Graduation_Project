namespace DataAccess.Models
{
    public class Review : BaseModel
    {
        public int? UserId { get; set; }
        public virtual User? Reviewer { get; set; }

        public int CraftsmanId { get; set; }
        public virtual Craftsman Craftsman { get; set; } = null!;

        public int Stars { get; set; }
        public string Comment { get; set; } = null!;
        public bool IsVerified { get; set; }
        public bool IsApproved { get; set; } 
    }
}
