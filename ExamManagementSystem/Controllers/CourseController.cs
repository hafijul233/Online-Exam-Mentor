using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;

namespace ExamManagementSystem.Controllers
{
    public class CourseController : Controller
    {
        CourseManager newCourseManager = new CourseManager();
        // GET: Course
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Entry()
        {
            List<SelectListItem> ViewOrglist = new List<SelectListItem>();

            List<SelectedItemInfo> orglist = new List<SelectedItemInfo>();

            orglist = newCourseManager.GetOrganizationListFromRepo();
            foreach (SelectedItemInfo orgItem in orglist)
            {
                ViewOrglist.Add(new SelectListItem() { Text = orgItem.Name, Value = orgItem.Id.ToString() });
            }

            ViewBag.Organizationitems = ViewOrglist;
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }


    }
}