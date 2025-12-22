using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class AddCraftsmanDTO
    {
        public int UserId { get; set; }
        public int ProfessionId { get; set; }

        public string Bio { get; set; } = string.Empty;
        public int ExperienceYears { get; set; }

        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }

        public List<int> CityIds { get; set; } = new();
        public List<int> SkillIds { get; set; } = new();
    }
}
