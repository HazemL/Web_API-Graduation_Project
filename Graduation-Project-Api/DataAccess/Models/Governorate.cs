using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Governorate : BaseModel
    {
        public string Name { get; set; }
        public string ArabicName { get; set; }

        public ICollection<City>? Cities { get; set; }
    }

}
