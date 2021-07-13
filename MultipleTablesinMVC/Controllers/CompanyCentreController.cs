using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultipleTablesinMVC.Models;
namespace MultipleTablesinMVC.Controllers
{
    public class CompanyCentreController : Controller
    {
        // GET: CompanyCentre
        public ActionResult Index()
        {
            //add db context
            CompanyDBEntities3 cd3 = new CompanyDBEntities3();
            //create list of company centres and add to db context object
            List<CompanyCentre> cc = cd3.CompanyCentres.ToList();
            return View(cc);
            
        }

        public ActionResult Details(int companyid)  //passing parameter myid
        {
            //add db context
            CompanyDBEntities3 cd3 = new CompanyDBEntities3();
            //create companycentre objectn and add to add db context
            CompanyCentre ce = cd3.CompanyCentres.SingleOrDefault(x => x.ccId == companyid);


            return View(ce);
        }
    }
}