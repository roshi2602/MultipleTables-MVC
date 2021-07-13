using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultipleTablesinMVC.Models;
namespace MultipleTablesinMVC.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult MyCompany()
        {
            //add db context
            CompanyDBEntities3 cd3 = new CompanyDBEntities3();
            //create list of company centres and add to db context object
            List<Company> cc = cd3.Companies.ToList();
            return View(cc);
        }
    }
}