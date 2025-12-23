using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs.Report
{
    public class GetAllReportDTO
    {
        public int Id { get; set; }
        public string Reason { get; set; }
        public bool IsResolved { get; set; }

    }
}
