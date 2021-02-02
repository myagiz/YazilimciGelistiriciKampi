using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Abstract;
using Business.Concrete;
using Entities;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IUserService _userManager = new UserManager();
        private ISalesService _salesManager = new SalesManager();
        public ActionResult Index(User user)
        {
           _userManager.Login(user);

            return View();
        }

       
    }
}