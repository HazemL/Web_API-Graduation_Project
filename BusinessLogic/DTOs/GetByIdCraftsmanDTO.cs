using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class GetByIdCraftsmanDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public int ExperienceYears { get; set; }
        public string ProfessionName { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public bool IsVerified { get; set; }

        public ICollection<string> Skills { get; set; }
        public ICollection<string> GalleryUrls { get; set; }
        public ICollection<ReviewDTO> Reviews { get; set; } 

    }
}
