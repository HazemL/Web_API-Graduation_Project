using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class GetAllCraftsmanDTO
    {
        
            public int Id { get; set; }
            public string FullName { get; set; }
            public string? ProfileImageUrl { get; set; }
            public string ProfessionName { get; set; }

            public int ExperienceYears { get; set; }
            public decimal MinPrice { get; set; }
            public decimal MaxPrice { get; set; }
            public bool IsVerified { get; set; }

            public double AverageRating { get; set; } 
            public int ReviewsCount { get; set; }
        
    }
}
