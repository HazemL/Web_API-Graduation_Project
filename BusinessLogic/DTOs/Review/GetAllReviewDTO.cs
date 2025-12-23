using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs.Review
{
    public class GetAllReviewDTO
    {
        public int Id { get; set; }
        public int Rate { get; set; }
        public string? Comment { get; set; }
        public bool IsApproved { get; set; } = false;
    }
}
