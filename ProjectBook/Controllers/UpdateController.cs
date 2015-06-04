using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectScreen.Models;
using DataAccess;

namespace ProjectScreen.Controllers
{  [AuthorizeUser]
    public class UpdateController : Controller
    {


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
                DataAccess.ProjectQuery.AddProject(proje);
                return RedirectToAction("Index", "Home");
            }

            return View(proje);
        }

        public ActionResult Edit(int id)
        {
            Project pro = DataAccess.ProjectQuery.FindProject(id);
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
            if (ModelState.IsValid)
            {
                DataAccess.ProjectQuery.UpdateProjectState(pro);
                return RedirectToAction("Index", "Home");
            }
            return View(pro);
        }

        // GET: /Update/Delete/5

        public ActionResult Delete(int id=0)
        {
            Project pro = DataAccess.ProjectQuery.FindProject(id);
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
            Project book = DataAccess.ProjectQuery.FindProject(id);
            DataAccess.ProjectQuery.RemoveProject(book);
            return RedirectToAction("Index", "Home");
        }

       
    }
}
