using HSMedicalJournalsDB.Models;
using HSMedicalJournalsDB.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;

namespace HSMedicalJournalsDB.Controllers
{
    public class UserController : Controller
    {
        string strConn = "Data Source=(LocalDb)\\MSSQLLocalDB; Initial Catalog=HSMedicalJournalsDB;Integrated Security=True";


        // GET: User
        public ActionResult Index()
        {
            using (HSContext db = new HSContext())
            {
                return View(db.Users.ToList());
            }                
        }

        public ActionResult Register()
        {
            if (Session["userId"] != null)
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid){
                using (HSContext db = new HSContext())
                {
                    Crypto c = new Crypto();

                    user.Password = c.Encriptar(user.Password);
                    user.PasswordConfirmation = c.Encriptar(user.PasswordConfirmation);
                    db.Users.Add(user);                    
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = user.FirstName + " " + user.LastName + " is Successfully Registered!";
            }
            return View();  
        }
                
        public ActionResult Login()
        {
            if (Session["userId"] != null)
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }else
            {
                return View();
            }            
        }

        [HttpPost]
        public ActionResult Login(User user)
        {            
            using (HSContext db = new HSContext())
            {
                Crypto c = new Crypto();

                string _u = user.UserName;
                string _p = c.Encriptar(user.Password);

                var usr = db.Users.Where(u => u.UserName == _u && u.Password == _p).FirstOrDefault();

                if (usr != null)
                {
                    using (SqlConnection conn = new SqlConnection(strConn))
                    {
                        conn.Open();

                        string cadena = "select Id from Users where UserName = @1";
                        SqlCommand cmd = new SqlCommand(cadena, conn);
                        cmd.Parameters.AddWithValue("@1", user.UserName.ToString());
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        Session["userId"] = ds.Tables[0].Rows[0][0].ToString();
                        Session["userName"] = user.UserName.ToString();

                        return RedirectToAction("Index", "Home", new { area = "" });
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password!");
                }                
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["userId"] != null)
            {
                return View();
            }else
            {
                return RedirectToAction("Login");
            }
        }
    }
}