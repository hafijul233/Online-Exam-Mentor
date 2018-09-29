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

        public List<SelectedItemInfo> GetOrganizationList()
        {
            List<SelectedItemInfo> SelectedOrgList = new List<SelectedItemInfo>();

            var SelectedItem = (from organization in _EMSDb.Organizations
                select new { Id = organization.Id, Name = organization.Name }).ToList();

            SelectedItem.ToList();

            foreach (var item in SelectedItem)
            {
                SelectedOrgList.Add(new SelectedItemInfo() { Id = item.Id, Name = item.Name });
            }

            return SelectedOrgList;
        }
    }
}
