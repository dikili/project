using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectScreen.Models;

namespace ProjectScreen.Controllers
{
    public class UpdateController : Controller
    {
        //
        // GET: /Update/
        private ProjectsDb db = new ProjectsDb();
       

        //
        // GET: /Update/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Update/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Project proje)
        {
            if (ModelState.IsValid)
            {
                db.Projects.Add(proje);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(proje);
        }

        //
        // POST: /Update/Create


        //
        // GET: /Update/Edit/5

        public ActionResult Edit(int id)
        {
            Project pro = db.Projects.Find(id);
            if (pro == null)
            {
                return HttpNotFound();
            }
            return View(pro);
        }

        //
        // POST: /Update/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Project pro)
        {
            //var pro = new Project();
            //pro.Date = Convert.ToDateTime(Request["Date"], System.Globalization.CultureInfo.GetCultureInfo("en-GB"));
            //pro.Name=Request["Name"];
            //pro.Pmam=Request["Pmam"];
            //pro.Description=Request["Description"];

            if (ModelState.IsValid)
            {
                
                db.Entry(pro).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(pro);
        }

        //
        // GET: /Update/Delete/5

        public ActionResult Delete(int id=0)
        {
            Project pro = db.Projects.Find(id);
            if (pro == null)
            {
                return HttpNotFound();
            }
            
            return View(pro);
        }

        //
        // POST: /Update/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Project book = db.Projects.Find(id);
            db.Projects.Remove(book);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
