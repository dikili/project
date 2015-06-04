﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ProjectScreen.Controllers
{   [AllowAnonymous]
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.User user)
        {
            if (ModelState.IsValid)
            { 
             if(user.IsValid(user.UserName,user.Password))
             {
                 FormsAuthentication.SetAuthCookie(user.UserName,user.RememberMe);
                HttpContext.Items.Add("status","LoginIsASuccess");
                 return RedirectToAction("Index", "Home");
             }
             else
             {
                ModelState.AddModelError("","Login data is incorrect");
             }
            }
            return View(user);
        }



        [HttpGet]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "User");
        }

    }
}