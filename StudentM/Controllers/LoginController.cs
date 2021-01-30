using StudentM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentM.Controllers
{
    public class LoginController : Controller
    {
        SMSEntities db = new SMSEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

       [HttpPost]
       [ValidateAntiForgeryToken]
        public ActionResult Index(user objchk)
        {
            if(ModelState.IsValid)
            {
                using (SMSEntities db = new SMSEntities())
                {

                    var obj = db.users.Where(a => a.Username.Equals(objchk.Username) && a.Password.Equals(objchk.Password)).FirstOrDefault();

                    if (obj != null)
                    {
                        Session["UserID"] = obj.id.ToString();
                        Session["UserName"] = obj.Username.ToString();

                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {

                        ModelState.AddModelError("", "The UserName or Password Incorrect");
                    }
                }

            }

            
            return View(objchk);
        }

        public ActionResult Logout()
        {

            Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}