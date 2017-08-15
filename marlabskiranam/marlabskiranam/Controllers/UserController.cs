using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using marlabskiranam.Models;

namespace marlabskiranam.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Homepage()
        {
            return View();
        }
        public ActionResult Signin()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Signin(login user)
        {
            if (ModelState.IsValid)
            {
                using (kiranamContext kc = new kiranamContext())
                {

                    var v = (kc.mvc_users.Where(c => c.EmailID == user.EmailID && c.Password == user.Password)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["username"] = user.EmailID;
                        return RedirectToAction("Profilepage","User");
                    }
                    else
                    {
                        Response.Write("Invalid Credentials");
                        return RedirectToAction("Signin", "User");
                    }
                }

            }
            
            return View();
        }

        public ActionResult Profilepage()
        {
            if (Session["username"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Signin","User");
            } 
        }

        public ActionResult Signup()
        {
            return View();
        }
    }
}