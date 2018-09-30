using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataBaseContext;
using Models;

namespace ExamManagementSystem.Controllers
{
    public class TrainerController : Controller
    {
        AbcExamManagerDb _EMSDb = new AbcExamManagerDb();
        // GET: Trainer
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
            //Batch
            List<SelectedItemInfo> SelectedBatchList = new List<SelectedItemInfo>();
            List<SelectListItem> ViewBatchlist = new List<SelectListItem>();

            var SelectedBatchItem = (from batch in _EMSDb.Batches
                select new { Id = batch.Id, Name = batch.BatchNo.ToString() }).ToList();

            SelectedBatchItem.ToList();

            foreach (var item in SelectedBatchItem)
            {
                SelectedBatchList.Add(new SelectedItemInfo() { Id = item.Id, Name = item.Name });
            }

            foreach (SelectedItemInfo BatchItem in SelectedBatchList)
            {
                ViewBatchlist.Add(new SelectListItem() { Text = BatchItem.Name, Value = BatchItem.Id.ToString() });
            }

            ViewBag.BatchId = ViewBatchlist;

            return View();
        }

        public ActionResult Search()
        {
            return View();
        }

    }
}