using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectScreen.Models
{
    public class ProjectsDb :DbContext
    {

       
        public ProjectsDb() :base("name=Projectdb")
        {
        
        
        }
        public DbSet<Project> Projects { get; set; }
    }
}