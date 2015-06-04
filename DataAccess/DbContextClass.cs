using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProjectScreen.Models;


namespace DataAccess
{
    public class DbContextClass : DbContext
    {

            public DbContextClass()
                : base("name=Projectdb")
            {


            }
            public DbSet<Project> Projects { get; set; }


       
    }
}
