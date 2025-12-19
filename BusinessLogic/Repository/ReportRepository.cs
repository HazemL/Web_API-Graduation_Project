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
    public class ReportRepository:GeneralRepository<Report>,IGeneralRepository<Report>
    {
        public ReportRepository(Context context): base(context) { }
    }
}
