using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;

namespace MvcCvProject.Controllers
{
    public class ProjectController : Controller
    {

		GenericRepository<TblProjects> repo = new GenericRepository<TblProjects>();
		public ActionResult Index()
        {
            var projects = repo.List();
            return View(projects);
        }

        [HttpGet]
        public ActionResult AddProject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProject(TblProjects project)
        {
			if (ModelState.IsValid)
			{
				repo.TAdd(project);
				return RedirectToAction("Index");
			}
			else
			{
				return View("AddProject");
			}
		}

        public ActionResult DeleteProject(int id)
        {
            TblProjects pro = repo.Find(x => x.id == id);
			if (pro != null)
			{
				repo.TRemove(pro);
				return RedirectToAction("Index");
			}
			else
			{
				return HttpNotFound();
			}
		}

		[HttpGet]
        public ActionResult UpdateProject(int id)
        {
			TblProjects pro = repo.Find(x => x.id == id);
			if (pro != null)
			{
				return View(pro);
			}else
			{
				return HttpNotFound();
			}

		}

		[HttpPost]
		public ActionResult UpdateProject(TblProjects pro)
		{
			TblProjects project = repo.Find(x => x.id == pro.id);
			if (project != null)
			{
				project.title = pro.title;
				project.description = pro.description;
				project.tools = pro.tools;
				repo.TUpdate(project);
				return RedirectToAction("Index");
			}
			else
			{
				return View("UpdateProject");

			}
		}
	}
}