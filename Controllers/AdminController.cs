using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;

namespace MvcCvProject.Controllers
{
	[Authorize]
	public class AdminController : Controller
	{
		GenericRepository<TblAdmin> repo = new GenericRepository<TblAdmin>();
		public ActionResult Index()
		{
			var value = repo.List();
			return View(value);
		}

		[HttpGet]
		public ActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Add(TblAdmin t)
		{
			repo.TAdd(t);
			return RedirectToAction("Index");
		}

		public ActionResult Delete(int id)
		{
			TblAdmin t = repo.Find(x => x.id == id);
			repo.TRemove(t);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public ActionResult Update(int id)
		{
			TblAdmin user = repo.Find(x => x.id == id);
			return View(user);
		}

		[HttpPost]
		public ActionResult Update(TblAdmin t)
		{
			TblAdmin user = repo.Find(x => x.id == t.id);
			user.username= t.username;
			user.password= t.password;
			repo.TUpdate(user);
			return RedirectToAction("Index");
		}
	}
}