using Microsoft.Ajax.Utilities;
using ProjectScreen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using DataAccess;


namespace ProjectScreen.Controllers
{
     [AuthorizeUser]
    public class HomeController : Controller
    {
         DataAccess.DbContextClass _db = new DataAccess.DbContextClass();

        [HttpGet]
        public ActionResult Index()
        {
            //var model = _db.Projects.ToList();

            var model = from r in _db.Projects
                orderby r.Date ascending 
                select r;
              
            
            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null) {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            string pass=ConfigurationManager.AppSettings["pass"];

            if (ModelState.IsValid)
            {
                //if (pass == user.Pass)
                //{
                //    return RedirectToAction("Index", "Home");
                //}
                //else
                //{
                //    ModelState.AddModelError("", "Login data is incorrect!");
                //}
            }

            return View(user);

        }

    }
}
