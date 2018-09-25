using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Organization
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string About { get; set; }
        public string Logo { get; set; }

    }
}
