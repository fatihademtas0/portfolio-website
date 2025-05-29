using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCvProject.Controllers
{
	public class ExperienceController : Controller
	{
		ExperienceRepository repo = new ExperienceRepository();
		public ActionResult Index()
		{
			var values = repo.List();
			return View(values);
		}

		[HttpGet]
		public ActionResult AddExperience()
		{
			return View();
		}

		[HttpPost]
		public ActionResult AddExperience(TblExperiences t)
		{
			repo.TAdd(t);
			return RedirectToAction("Index");
		}

		public ActionResult DeleteExperience(int id)
		{
			TblExperiences t = repo.Find(x => x.id == id);
			repo.TRemove(t);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public ActionResult GetExperience(int id)
		{
			TblExperiences experience = repo.Find(x => x.id == id);
			return View(experience);
		}

		[HttpPost]
		public ActionResult GetExperience(TblExperiences t)
		{
			TblExperiences experience = repo.Find(x => x.id == t.id);
			experience.title = t.title;
			experience.subtitle = t.subtitle;
			experience.description = t.description;
			experience.date = t.date;
			repo.TUpdate(experience);
			return RedirectToAction("Index");
		}
	}
}