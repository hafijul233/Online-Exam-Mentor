using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using DataBaseContext;
using Models;

namespace ExamManagementSystem.Controllers
{
    public class OrganizationController : Controller
    {
        OrganizationManager newOrganizationManager = new OrganizationManager();

        AbcExamManagerDb _EMSDb = new AbcExamManagerDb();
        //
        // GET: /Organization/
        public ActionResult Index()
        {
            List<Organization> SelectedOrgList = new List<Organization>();
            
            var SelectedOrgItem = (from organization in _EMSDb.Organizations
                select organization).ToList();

            SelectedOrgItem.ToList();

            ViewBag.Organizations = SelectedOrgItem;

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