using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeManagement.Models;
namespace EmployeeManagement.Controllers
{
   
    public class ProfileController : Controller
    {
        private Manage db = new Manage();
        // GET: Profile
        public ActionResult displayProfile()
        {
            
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}