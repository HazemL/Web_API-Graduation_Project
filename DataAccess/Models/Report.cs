namespace DataAccess.Models
{
    public class Report : BaseModel
    {
        public int ReporterUserId { get; set; }
        public virtual User Reporter { get; set; } = null!;

        public int CraftsmanId { get; set; }
        public virtual Craftsman ReportedCraftsman { get; set; } = null!;

        public string Message { get; set; } = null!;
        public string Status { get; set; } = null!; // Pending, Resolved
    }
}
