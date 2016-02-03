using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Temp.Models;
using Temp.Models.db;


namespace Temp.Controllers
{
    public class HomeController : Controller
    {
        Mydb db = new Mydb();
        // GET: Home
        public ActionResult Index()
        {
            List<User> u = db.users.ToList();
            ViewBag.Data = u;
            return View();
        }
        [HttpPost]
        public ActionResult Index(User user)
        {
            db.users.Add(user);
            db.SaveChanges();
            List<User> u = db.users.ToList();
            ViewBag.Data = u;
            return View();
        }
        
    }
}