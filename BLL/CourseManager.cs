using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository;

namespace BLL
{
    public class CourseManager
    {
        CourseRepository newCourseRepository = new CourseRepository();

        public bool ManagerEntry(Course newCourse)
        {
            int confirm = newCourseRepository.RepositoyEntry(newCourse);

            if (confirm > 0)
            {
                return true;
            }
            return false;
        }
    }
}
