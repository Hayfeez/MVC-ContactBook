using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactBook_MVC.Models;

namespace ContactBook_MVC.Controllers
{
    public class HomeController : Controller
    {
        private ContactBookModel db = new ContactBookModel();

        public ActionResult Index()
        {
            var contacts = db.Contacts.Include(s => s.Country).Include(s => s.State).ToList();
            return View(contacts);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}