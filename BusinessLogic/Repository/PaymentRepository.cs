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
    public class PaymentRepository :GeneralRepository<Payment>,IGeneralRepository<Payment>
    {
        public PaymentRepository(Context context) : base(context) { }
    }
}
