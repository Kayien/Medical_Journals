using HSMedicalJournalsDB.Models;
using HSMedicalJournalsDB.Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HSMedicalJournalsDB.Controllers
{
    public class JournalController : Controller
    {
        string strConn = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=HSMedicalJournalsDB;Integrated Security=True";

        // GET: Journal
        public ActionResult GetAll()
        {
            if (Session["userId"] != null)
            {
                using (HSContext db = new HSContext())
                {
                    return View(db.Journals.ToList());
                }         
            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
        }

        public ActionResult GetById(string username)
        {

            if (Session["userId"] != null)
            {
                using (HSContext db = new HSContext())
                {
                    return PartialView(db.Journals.Where(j => j.Publisher.UserName == username).ToList());
                }
            }else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
        }

        public ActionResult UploadFile()
        {
            if (Session["userId"] != null)
            {
                return View();               
            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
        }

        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            if (Session["userId"] != null)
            {
                if (file != null)
                {
                    TempData["fileToUpload"] = file;

                    return RedirectToAction("UploadDescription", new { area = "" });
                }else
                {
                    return View();
                }
            }else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
        }
        
        public ActionResult UploadDescription()
        {
            if (Session["userId"] != null)
            {
                HttpPostedFileBase file = (HttpPostedFileBase)TempData["fileToUpload"];

                if (file != null)
                {
                    HSContext db = new HSContext();
                    ViewBag.Categories = new SelectList(db.Categories, "Id", "Name");
                    ViewBag.Editorials = new SelectList(db.Editorials, "Id", "Name");
                    TempData["fileToUpload"] = file;
                    return View();
                }
                else
                {
                    return RedirectToAction("UploadFile", new { area = "" });
                }
            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }                
        }

        [HttpPost]
        public ActionResult UploadDescription(Journal journal, FormCollection form)
        {
            if (Session["userId"] != null)
            {
                HttpPostedFileBase file = (HttpPostedFileBase)TempData["fileToUpload"];
                                
                string cat = form["Categories"].ToString();
                string edi = form["Editorials"].ToString();
                
                if (file == null)
                {
                    return RedirectToAction("UploadFile", new { area = "" });
                }
                else
                {
                    HSContext db = new HSContext();
                    
                    foreach (var user in db.Users)
                    {
                        if (user.UserName.Equals(Session["userName"].ToString()))
                        {
                            journal.Publisher = user;
                            break;
                        }
                    }

                    foreach (var category in db.Categories)
                    {
                        if (category.Id == int.Parse(cat))
                        {
                            journal.Category = category;
                            break;
                        }
                    }

                    foreach (var editorial in db.Editorials)
                    {
                        if (editorial.Id == int.Parse(edi))
                        {
                            journal.Editorial = editorial;
                            break;
                        }
                    }

                    string fileName = DateTime.Now.ToString("ddMMyyyyHHmmssfff");
                    string serverPath = Server.MapPath("~/Files/"+fileName+".pdf");                    
                    file.SaveAs(serverPath);
                    journal.FilePath = fileName;
                    
                    db.Journals.Add(journal);
                    db.SaveChanges();

                    db.Dispose();
                    return RedirectToAction("Index", "Home", new { area = "" });
                }                
            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
        }

        public ActionResult MySubscriptions()
        {
            if (Session["userId"] != null)
            {
                using (HSContext db = new HSContext())
                {
                    using (SqlConnection conn = new SqlConnection(strConn))
                    {
                        conn.Open();

                        string cadena = "select j.* from Journals as j left join Subscriptions as s on j.Id = s.Journal_Id " +
                                        "where s.User_Id = @1";
                        SqlCommand cmd = new SqlCommand(cadena, conn);
                        cmd.Parameters.AddWithValue("@1", int.Parse(Session["userId"].ToString()));
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        List<Journal> journals = new List<Journal>();

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                Journal journal = new Journal();
                                journal.Id = (int)ds.Tables[0].Rows[i]["Id"];
                                journal.Name = ds.Tables[0].Rows[i]["Name"].ToString();
                                journal.Description = ds.Tables[0].Rows[i]["Description"].ToString();
                                journal.Price = (double)ds.Tables[0].Rows[i]["Price"];
                                journal.Editor = ds.Tables[0].Rows[i]["Editor"].ToString();
                                journal.Language = ds.Tables[0].Rows[i]["Language"].ToString();
                                journal.FilePath = ds.Tables[0].Rows[i]["FilePath"].ToString();
                                journal.PublicationDate = (DateTime)ds.Tables[0].Rows[i]["PublicationDate"];
                                journals.Add(journal);
                            }
                        }

                        return View(journals);
                    }
                }
            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
        }

        public ActionResult Subscribe()
        {
            if(Session["userId"] != null)
            {
                using (HSContext db = new HSContext())
                {
                    using (SqlConnection conn = new SqlConnection(strConn))
                    {
                        conn.Open();

                        string cadena = "select * from journals where Publisher_Id <> @1 and (Id not in (select Journal_Id from Subscriptions where User_Id = @1))";
                        
                        SqlCommand cmd = new SqlCommand(cadena, conn);
                        int uid = int.Parse(Session["userId"].ToString());
                        cmd.Parameters.AddWithValue("@1", int.Parse(Session["userId"].ToString()));

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        List<Journal> journals = new List<Journal>();

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            for (int i = 0; i< ds.Tables[0].Rows.Count; i++)
                            {
                                Journal journal = new Journal();
                                journal.Id = (int)ds.Tables[0].Rows[i]["Id"];
                                journal.Name = ds.Tables[0].Rows[i]["Name"].ToString();
                                journal.Description = ds.Tables[0].Rows[i]["Description"].ToString();
                                journal.Price = (double)ds.Tables[0].Rows[i]["Price"];
                                journal.Editor = ds.Tables[0].Rows[i]["Editor"].ToString();
                                journal.Language = ds.Tables[0].Rows[i]["Language"].ToString();
                                journal.FilePath = ds.Tables[0].Rows[i]["FilePath"].ToString();
                                journal.PublicationDate = (DateTime)ds.Tables[0].Rows[i]["PublicationDate"];
                                journals.Add(journal);
                            }
                        }

                        return View(journals);
                    }
                }
            }
            else
            {
                return RedirectToAction("My", "Home", new { area = "" });
            }                           
        }
        
        public ActionResult CancelSubscription(int? id)
        {
            if (Session["userId"] != null)
            {
                using (HSContext db = new HSContext())
                {
                    using (SqlConnection conn = new SqlConnection(strConn))
                    {
                        conn.Open();

                        string cadena = "delete from Subscriptions where User_Id = @1 and Journal_Id = @2";
                        SqlCommand cmd = new SqlCommand(cadena, conn);
                        cmd.Parameters.AddWithValue("@1", int.Parse(Session["userId"].ToString()));
                        cmd.Parameters.AddWithValue("@2", id);
                        cmd.ExecuteNonQuery();

                        return RedirectToAction("MySubscriptions", "Journal", new { area = "" });
                    }
                }
            }else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
        }

        public ActionResult DeletePublication(int? id)
        {

            if (Session["userId"] != null)                
            {
                using (HSContext db = new HSContext())
                {
                    using (SqlConnection conn = new SqlConnection(strConn))
                    {
                        conn.Open();

                        string serverPath = Server.MapPath("~/Files/");
                        string[] pdfList = Directory.GetFiles(serverPath, "*.pdf");

                        Journal journal;

                        foreach (var _journal in db.Journals)
                        {
                            if (_journal.Id == id)
                            {
                                journal = _journal;

                                foreach (string pdf in pdfList)
                                {
                                    // Remove path from the file name.
                                    string fName = pdf.Substring(serverPath.Length);
                                    fName = fName.Replace(".pdf", "").Trim();

                                    if (fName.Equals(journal.FilePath))
                                    {
                                        System.IO.File.Delete(serverPath + fName + ".pdf");

                                        string cadena = "delete from Journals where Id = @1";
                                        SqlCommand cmd = new SqlCommand(cadena, conn);
                                        cmd.Parameters.AddWithValue("@1", id);
                                        cmd.ExecuteNonQuery();
                                        break;
                                    }
                                }
                                break;
                            }
                        }
                        return RedirectToAction("Index", "Home", new { area = "" });
                    }
                }
            }else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
        }

        public ActionResult ConfirmSubscription(int? id)
        {
            if (Session["userId"] != null)
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    string cadena = "insert into Subscriptions (User_Id,Journal_Id,SubscriptionDate,ExpirationDate) values (@1,@2,@3,@4)";
                    SqlCommand cmd = new SqlCommand(cadena, conn);
                    cmd.Parameters.AddWithValue("@1", int.Parse(Session["userId"].ToString()));
                    cmd.Parameters.AddWithValue("@2", id);
                    cmd.Parameters.AddWithValue("@3", DateTime.Now);
                    cmd.Parameters.AddWithValue("@4", DateTime.Now.AddYears(1));
                    cmd.ExecuteNonQuery();

                    return RedirectToAction("MySubscriptions", "Journal", new { area = "" });
                }
            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
        }        
    }
}