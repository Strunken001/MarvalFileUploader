using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class FileUpdateDTO
    {
        public string? FirstName { get; set; }
        public string? Surname { get; set; }
        public int? Age { get; set; }
        public string? Sex { get; set; }
        public string? Mobile { get; set; }
        public string? Active { get; set; }
    }
}
