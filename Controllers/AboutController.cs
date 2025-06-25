using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;

namespace MvcCvProject.Controllers
{
	public class AboutController : Controller
	{
		GenericRepository<TblAbout> repo = new GenericRepository<TblAbout>();
		public ActionResult Index()
		{
			var value = repo.List();
			return View(value);
		}

		[HttpGet]
		public ActionResult GetAbout(int id)
		{
			var value = repo.TGet(id);
			return View(value);
		}

		[HttpPost]
		public ActionResult GetAbout(TblAbout p1)
		{
			var deger = repo.TGet(p1.id);
			deger.name = p1.name;
			deger.lastname = p1.lastname;
			deger.address = p1.address;
			deger.email = p1.email;
			deger.phone = p1.phone;
			deger.description = p1.description;
			deger.image = p1.image;
			repo.TUpdate(deger);
			return RedirectToAction("Index");
		}
	}
}