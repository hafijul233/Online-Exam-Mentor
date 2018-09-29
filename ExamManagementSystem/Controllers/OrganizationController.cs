using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Models;

namespace ExamManagementSystem.Controllers
{
    public class OrganizationController : Controller
    {
        OrganizationManager newOrganizationManager = new OrganizationManager();
        //
        // GET: /Organization/
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
        public ActionResult Entry(Organization newOrganization)
        {
            bool isAdded;

            if (ModelState.IsValid)
            {
                isAdded = newOrganizationManager.ManagerEntry(newOrganization);

                if (isAdded == true)
                {
                    ViewBag.Organization = newOrganization;

                    return View("Confirm");
                }

                ViewBag.Organization = newOrganization;

                return View("Confirm");

            }

                ViewBag.Organization = newOrganization;
            
               return View();    
        }

        [HttpGet]
        public ActionResult Search()
        {
            

            return View();
        }

        [HttpPost]
        public ActionResult Search(Organization searchOrganization)
        {
            return View();
        }

        public ActionResult Information()
        {
            return View();
        }

        public ActionResult Confirm()
        {
            return View();
        }

    }
}