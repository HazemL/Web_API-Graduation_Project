using System;

namespace DataAccess.Models
{
    public class RevokedToken
    {
        public int Id { get; set; }

        // JTI اللي اتلغى
        public string Jti { get; set; } = null!;
        // وقت الإلغاء
        public DateTime RevokedAt { get; set; }
    }
}
