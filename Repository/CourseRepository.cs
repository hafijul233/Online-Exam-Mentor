using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseContext;
using Models;

namespace Repository
{
    public class CourseRepository
    {
        AbcExamManagerDb _EMSDb = new AbcExamManagerDb();
        public int RepositoyEntry(Course newCourse)
        {

            _EMSDb.Courses.Add(newCourse);

            int confirm = _EMSDb.SaveChanges();

            return confirm;
        }
    }
}
