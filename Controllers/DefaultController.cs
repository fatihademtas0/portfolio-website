using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProject.Models.Entity;

namespace MvcCvProject.Controllers
{
    public class DefaultController : Controller
    {
		DbCvEntities2 db = new DbCvEntities2();
		public ActionResult Index()
        {
            var values = db.TblAbout.ToList();		
			return View(values);
        }

        public PartialViewResult Experiences()
        {
            var values = db.TblExperiences.ToList();
            return PartialView(values);
        }

		public PartialViewResult Projects()
		{
			var values = db.TblProjects.ToList();
			return PartialView(values);
		}

		public PartialViewResult Education()
		{
			var values = db.TblEducation.ToList();
			return PartialView(values);
		}
	}
}