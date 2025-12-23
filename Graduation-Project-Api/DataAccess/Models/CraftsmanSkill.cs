using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{

    public class CraftsmanSkill : BaseModel
    {
        public int CraftsmanId { get; set; }
        public Craftsman? Craftsman { get; set; }

        public int SkillId { get; set; }
        public Skill? Skill { get; set; }

        public string? ProficiencyLevel { get; set; }
    }

}
