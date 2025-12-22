using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class AddProfessionsDTO
    {
        [Required(ErrorMessage = "English Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Arabic Name is required")]
        public string ArabicName { get; set; }

        public string? Description { get; set; }
    }
}
