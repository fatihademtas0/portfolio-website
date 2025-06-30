using MvcCvProject.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcCvProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public ActionResult Index(TblAdmin t)
		{
            DbCvEntities2 db = new DbCvEntities2();
            var info = db.TblAdmin.FirstOrDefault(x => x.username == t.username && x.password == t.password);

            if(info != null)
            {
                FormsAuthentication.SetAuthCookie(info.username, false);
                Session["Username"] = info.username.ToString();
                return RedirectToAction("Index", "About");
            }else
            {
                return RedirectToAction("Index", "Login");
            }
		}

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
	}
}