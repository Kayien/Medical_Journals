using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HSMedicalJournalsDB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Login()
        {
            if (Session["userId"] != null)
            {
                return RedirectToAction("LoggedIn");
            }
            else
            {
                return RedirectToAction("Login","User",new { area = ""});
            }
        }
        
        public ActionResult Logout()
        {
            Session["userId"] = null;
            Session["userName"] = null;
            Session["userEmail"] = null;

            return RedirectToAction("Index");
        }
    }
}