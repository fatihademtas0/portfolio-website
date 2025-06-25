using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;

namespace MvcCvProject.Controllers
{
    public class ContactController : Controller
    {
		GenericRepository<TblContact> repo = new GenericRepository<TblContact>();
		public ActionResult Index()
        {
            var contacts = repo.List();
            return View(contacts);
        }
    }
}