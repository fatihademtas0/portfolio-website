using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;

namespace MvcCvProject.Controllers
{
    public class InterestController : Controller
    {
		GenericRepository<TblInterests> repo = new GenericRepository<TblInterests>();
		public ActionResult Index()
        {
			var interests = repo.List();
			return View();
        }

		public ActionResult DeleteInterest(int id)
		{
			TblInterests interest = repo.Find(x => x.id == id);
			if (interest != null)
			{
				repo.TRemove(interest);
				return RedirectToAction("Index");
			}
			else
			{
				return HttpNotFound();
			}
		}

		[HttpGet]
		public ActionResult UpdateInterest(int id)
		{
			var interest = repo.Find(x => x.id == id);
			return View(interest);
		}

		[HttpPost]
		public ActionResult UpdateInterest(TblInterests t)
		{
			var interest= repo.Find(x => x.id == t.id);
			interest.description1 = t.description1;
			interest.description2 = t.description2;
			repo.TUpdate(interest);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public ActionResult AddInterest()
		{
			return View();
		}

		[HttpPost]
		public ActionResult AddInterest(TblInterests t)
		{
			repo.TAdd(t);
			return RedirectToAction("Index");
		}
	}
}