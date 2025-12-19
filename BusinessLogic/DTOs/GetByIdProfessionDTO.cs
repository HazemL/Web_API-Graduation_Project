using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class GetByIdProfessionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ArabicName { get; set; }
        public string? Description { get; set; }
        public int CraftsmenCount { get; set; }
    }
}
