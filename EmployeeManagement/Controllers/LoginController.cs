using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeManagement.Models;
using System.Web.Security;
using System.Data.Entity;

namespace EmployeeManagement.Controllers
{
    public class LoginController : Controller
    {
        private EmplManageContext objContext = new EmplManageContext();

        // GET: Login
        public ActionResult Index()
        {
            return View("Login");
        }

        public ActionResult Get(int id)
        {
            return View();
        }
        [Authorize]
        public ActionResult ManageLogin()
        {
            var loginDetails = objContext.Logins.ToList();
            return View(loginDetails);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddLogin(tblLogin tblLogin)
        {
            tblLogin.ModifiedDate = DateTime.Now;
            objContext.Logins.Add(tblLogin);        
            objContext.SaveChanges();
            return RedirectToAction("ManageLogin");
        }

        [HttpPost]
        public ActionResult Login(tblLogin tblLogin)
        {
            var userDetails = objContext.Logins.Where(l => l.Username == tblLogin.Username && l.Password == tblLogin.Password).FirstOrDefault();
            if(userDetails!=null)
            {
                FormsAuthentication.SetAuthCookie(userDetails.LoginName, false);
                Session["Username"] = userDetails.LoginName;
                Session["Rights"] = userDetails.Rights.ToString();
                return View("Default");
            }
            else
            {
                return RedirectToAction("Index");
            }
         
        }

        [Authorize]
        public ActionResult Logout()
        {
            Session["Username"] = null;
            Session["Rights"] = null;
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}