using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;

namespace ExamManagementSystem.Controllers
{
    public class BatchController : Controller
    {
        BatchManager newBatchManager = new BatchManager();
        // GET: Batch
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Entry()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Entry(Batch newBatch)
        {
            bool isAdded;

            if (ModelState.IsValid)
            {
                isAdded = newBatchManager.ManagerEntry(newBatch);

                if (isAdded == true)
                {
                    ViewBag.Organization = newBatch;

                    return View("Information");
                }

                ViewBag.Organization = newBatch;

                return View("Information");

            }

            ViewBag.Organization = newBatch;

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