using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Interface;
using DataAccess.Context;
using DataAccess.Models;

namespace BusinessLogic.Repository
{
    public class SkillRepository:GeneralRepository<Skill>,IGeneralRepository<Skill>
    {
        public SkillRepository(Context context) : base(context) { }
    }
}
