using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;

namespace MvcCvProject.Controllers
{
    public class SocialMediaController : Controller
    {
		GenericRepository<TblSocial> repo = new GenericRepository<TblSocial>();
		public ActionResult Index()
        {
            var values = repo.List();
            return View(values);
        }

		[HttpGet]
		public ActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Add(TblSocial p1)
		{
			repo.TAdd(p1);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public ActionResult Update(int id)	
		{
			var value = repo.Find(x => x.id == id);
			return View(value);
		}

		[HttpPost]
		public ActionResult Update(TblSocial p1)
		{
			var value = repo.Find(x => x.id == p1.id);
			value.platform_name = p1.platform_name;
			value.link = p1.link;
			value.icon = p1.icon;
			repo.TUpdate(value);
			return RedirectToAction("Index");
		}

		public ActionResult Delete(int id)
		{
			TblSocial value = repo.Find(x => x.id == id);
			if (value != null)
			{
				repo.TRemove(value);
				return RedirectToAction("Index");
			}
			else
			{
				return HttpNotFound();
			}
		}
	}
}