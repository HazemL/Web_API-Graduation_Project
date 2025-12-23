using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs.Report
{
    
        public class GetReportByIdDTO
        {
            public int Id { get; set; }
            public int CraftsmanId { get; set; }
            public int UserId { get; set; }
            public string Reason { get; set; }
            public string? Description { get; set; }
            public bool IsResolved { get; set; }
        }
    

}
