using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProjectScreen.Models;
using DataAccess;

namespace ProjectScreen.Controllers
{
    public class ProjectController : ApiController
    {
        DbContextClass db = new DbContextClass();

        public IEnumerable<Project> GetAllProjects()
        {
            return DataAccess.ProjectQuery.GetAllProjects();
        }

        [HttpGet]
        public IHttpActionResult GetProject(int id)
        {
            var project = DataAccess.ProjectQuery.FindProject(id);

            if (project == null)
            {
                return Ok("Project not found!");
            }
            return Ok(project);
        }

        [HttpPost]
        public IHttpActionResult Save(Project project)
        {

            if (ModelState.IsValid)
            {
                DataAccess.ProjectQuery.UpdateProjectState(project);
                return Ok(project);
            }

            return Ok("Model state is not valid.");
        }

        
    }
}
