using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Helpers;
using System.Collections;
using ProjectScreen.Models;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;


namespace DataAccess
{
    public static class ProjectQuery
    {
       
        
        public static void AddProject(Project proje)
        {
           DbContextClass db = new DbContextClass(); 
           db.Projects.Add(proje);
           db.SaveChanges();
        }
        public static Project FindProject(int id)
        {
            DbContextClass db = new DbContextClass(); 
            return db.Projects.Find(id);
        }
        public static void UpdateProjectState(Project pro)
        {
            DbContextClass db = new DbContextClass();
            db.Entry(pro).State = EntityState.Modified;
            db.SaveChanges();
        }
        public static void RemoveProject(Project book)
        {
            DbContextClass db = new DbContextClass();
            db.Projects.Remove(book);
            db.SaveChanges();
        }
    }
}
