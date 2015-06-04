using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProjectScreen.Models;

namespace ProjectScreen.Controllers
{
    public class ProjectController : ApiController
    {
        Project[] projects = new Project[]
        {
          new Project {Id=1,Name="Project1",Pmam="TestUser1",Date=DateTime.Now},
          new Project {Id=2,Name="Project2",Pmam="TestUser2",Date=DateTime.Now},
          new Project {Id=3,Name="Project3",Pmam="TestUser3",Date=DateTime.Now},
          new Project {Id=4,Name="Project4",Pmam="TestUser4",Date=DateTime.Now}
        };


        public IEnumerable<Project> GetAllProjects()
        {
            return projects;
        }


        public IHttpActionResult GetProject(int id)
        {
            var project = projects.FirstOrDefault(p => p.Id == id);

            if (project == null)
            {
                return NotFound();
            }
            return Ok(project);

        }
    }
}
