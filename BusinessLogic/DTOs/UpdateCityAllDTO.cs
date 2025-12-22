using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class UpdateCityAllDTO
    {
        public string Name { get; set; }
        public string ArabicName { get; set; }
        public int GovernorateId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
