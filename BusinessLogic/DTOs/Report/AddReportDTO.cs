using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs.Report
{
    public class AddReportDTO
    {
        [Required]
        public int CraftsmanId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [StringLength(200)]
        public string Reason { get; set; }

        public string? Description { get; set; }
    }
}
