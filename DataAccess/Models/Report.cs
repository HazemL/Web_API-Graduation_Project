namespace DataAccess.Models
{
    public class Report : BaseModel
    {
        public int ReporterUserId { get; set; }
        public virtual User Reporter { get; set; }

        public int CraftsmanId { get; set; }
        public virtual Craftsman ReportedCraftsman { get; set; }

        public string Message { get; set; }
        public string Status { get; set; }

      
        public bool IsResolved { get; set; }
    }
}
