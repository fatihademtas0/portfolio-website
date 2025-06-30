using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProject.Models.Entity;

namespace MvcCvProject.Controllers
{
	[AllowAnonymous]
	public class DefaultController : Controller
	{
		DbCvEntities2 db = new DbCvEntities2();
		public ActionResult Index()
		{
			var values = db.TblAbout.ToList();
			return View(values);
		}



		public PartialViewResult SocialMedia()
		{
			var values = db.TblSocial.ToList();
			return PartialView(values);
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

		public PartialViewResult Skills()
		{
			var values = db.TblSkills.ToList();
			return PartialView(values);
		}

		public PartialViewResult Interests()
		{
			var values = db.TblInterests.ToList();
			return PartialView(values);
		}

		public PartialViewResult Certfications()
		{
			var values = db.TblCertfications.ToList();
			return PartialView(values);
		}

		public PartialViewResult Courses()
		{
			var values = db.TblCourses.ToList();
			return PartialView(values);
		}
		[HttpGet]
		public PartialViewResult Contact()
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult Contact(TblContact t)
		{
			t.date = DateTime.Parse(DateTime.Now.ToShortDateString());
			db.TblContact.Add(t);
			db.SaveChanges();
			return PartialView();
		}
	}
}