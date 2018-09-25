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
                    ModelState.AddModelError("", "There is an tar char error error occured");

                    ViewBag.Organization = newOrganization;

                    return View("Information");
                }

                ModelState.AddModelError("", "is added is false");

                ViewBag.Organization = newOrganization;

                return View("Information");

            }

                ModelState.AddModelError("", "There is an tar char error error occured");
                
                ViewBag.Organization = newOrganization;
            
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