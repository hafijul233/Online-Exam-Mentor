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
    public class BatchController : Controller
    {
        BatchManager newBatchManager = new BatchManager();
        AbcExamManagerDb _EMSDb = new AbcExamManagerDb();
        // GET: Batch
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Entry()
        {
            List<SelectedItemInfo> SelectedOrgList = new List<SelectedItemInfo>();
            List<SelectListItem> ViewOrglist = new List<SelectListItem>();

            var SelectedOrgItem = (from organization in _EMSDb.Organizations
                select new { Id = organization.Id, Name = organization.Name }).ToList();

            SelectedOrgItem.ToList();

            foreach (var item in SelectedOrgItem)
            {
                SelectedOrgList.Add(new SelectedItemInfo() { Id = item.Id, Name = item.Name });
            }

            foreach (SelectedItemInfo orgItem in SelectedOrgList)
            {
                ViewOrglist.Add(new SelectListItem() { Text = orgItem.Name, Value = orgItem.Id.ToString() });
            }

            ViewBag.OrganizationId = ViewOrglist;

            /// Course
            
            List<SelectedItemInfo> SelectedCourseList = new List<SelectedItemInfo>();
            List<SelectListItem> ViewCourselist = new List<SelectListItem>();

            var SelectedCourseItem = (from course in _EMSDb.Courses
                select new { Id = course.Id, Name = course.Name }).ToList();

            SelectedCourseItem.ToList();

            foreach (var item in SelectedCourseItem)
            {
                SelectedCourseList.Add(new SelectedItemInfo() { Id = item.Id, Name = item.Name });
            }

            foreach (SelectedItemInfo CourseItem in SelectedCourseList)
            {
                ViewCourselist.Add(new SelectListItem() { Text = CourseItem.Name, Value = CourseItem.Id.ToString() });
            }

            ViewBag.CourseId = ViewCourselist;
            
            return View();
        }

        [HttpPost]
        public ActionResult Entry(Batch newBatch)
        {
            if (ModelState.IsValid)
            {
                _EMSDb.Batches.Add(newBatch);
                if (_EMSDb.SaveChanges() > 0)
                {
                    ViewBag.batch = newBatch;
                    return View("Confirm");
                }
                ViewBag.batch = newBatch;
                return View("Confirm");
            }
            ViewBag.batch = newBatch;
            return View();
        }
        public ActionResult Search()
        {
            return View();
        }

        public ActionResult Information()
        {
            return View();
        }
    }
}