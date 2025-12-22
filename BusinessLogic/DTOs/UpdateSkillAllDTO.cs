using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class UpdateSkillAllDTO
    {
        [Required(ErrorMessage = "Skill name is required")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Arabic skill name is required")]
        [StringLength(100)]
        public string ArabicName { get; set; }
    }
}
