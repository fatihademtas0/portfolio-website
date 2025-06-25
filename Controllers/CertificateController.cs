using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;

namespace MvcCvProject.Controllers
{
    public class CertificateController : Controller
    {
        GenericRepository<TblCertfications> repo = new GenericRepository<TblCertfications>();
        public ActionResult Index()
        {
            var certificates = repo.List();
			return View(certificates);
        }

		public ActionResult DeleteCertificate(int id)
		{
			TblCertfications course = repo.Find(x => x.id == id);
			if (course != null)
			{
				repo.TRemove(course);
				return RedirectToAction("Index");
			}
			else
			{
				return HttpNotFound();
			}
		}

		[HttpGet]
		public ActionResult GetCertificate(int id)
		{
			var certificate = repo.Find(x => x.id == id);
			return View(certificate);
		}

		[HttpPost]
		public ActionResult GetCertificate(TblCertfications t)
		{
			var certificate = repo.Find(x => x.id == t.id);
			certificate.description = t.description;
			repo.TUpdate(certificate);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public ActionResult AddCertificate()
		{
			return View();
		}

		[HttpPost]
		public ActionResult AddCertificate(TblCertfications t)
		{
			repo.TAdd(t);
			return RedirectToAction("Index");
		}
	}
}