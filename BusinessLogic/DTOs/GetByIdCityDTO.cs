using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class GetByIdCityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ArabicName { get; set; }

        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public int GovernorateId { get; set; }
        public string GovernorateName { get; set; }

        public int CraftsmenCount { get; set; }
    }
}
