using Microsoft.Ajax.Utilities;
using ProjectScreen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectScreen.Controllers
{
    public class HomeController : Controller
    {
        ProjectsDb _db = new ProjectsDb();

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



    }
}
