using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Batch
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int CourseId { get; set; }
        public int BatchNo { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }


    }
}
