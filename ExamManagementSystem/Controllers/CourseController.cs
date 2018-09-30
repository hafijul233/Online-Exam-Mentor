using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;
using DataBaseContext;

namespace ExamManagementSystem.Controllers
{
    public class CourseController : Controller
    {
        CourseManager newCourseManager = new CourseManager();
        AbcExamManagerDb _EMSDb = new AbcExamManagerDb();
        // GET: Course
        public ActionResult Index()
        {
            List<Course> SelectedOrgList = new List<Course>();

            var SelectedOrgItem = (from organization in _EMSDb.Organizations
                select organization).ToList();

            SelectedOrgItem.ToList();

            ViewBag.Organizations = SelectedOrgItem;

            return View();
            return View();
        }

        [HttpGet] public ActionResult Entry()
        {
            List<SelectListItem> ViewOrglist = new List<SelectListItem>();

            List<SelectedItemInfo> orglist = new List<SelectedItemInfo>();

            orglist = newCourseManager.GetOrganizationListFromRepo();
            foreach (SelectedItemInfo orgItem in orglist)
            {
                ViewOrglist.Add(new SelectListItem() { Text = orgItem.Name, Value = orgItem.Id.ToString() });
            }

            ViewBag.OrganizationId = ViewOrglist;
            return View();
        }

        [HttpPost] public ActionResult Entry(Course newCourse){
            if (ModelState.IsValid)
            {
                _EMSDb.Courses.Add(newCourse);
                if (_EMSDb.SaveChanges() > 0)
                {
                    ViewBag.course = newCourse;
                    return View("Confirm");
                }
                ViewBag.course = newCourse;
                return View("Confirm");
            }
            ViewBag.course = newCourse;
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult Confirm()
        {
            return View();
        }


    }
}