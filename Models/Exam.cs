using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Exam
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int CourseId { get; set; }
        public string ExamType { get; set; }
        public string Code { get; set; }
        public string Topics { get; set; }
        public int FullMarks { get; set; }
        public double ExamDuration { get; set; } //hh:mm => hh.mm designed from logic section
    }
}
