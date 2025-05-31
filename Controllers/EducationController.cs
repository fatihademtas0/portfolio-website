using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;

namespace MvcCvProject.Controllers
{
    public class EducationController : Controller
    {
        GenericRepository<TblEducation> repo = new GenericRepository<TblEducation>();

		public ActionResult Index()
        {
            var educations = repo.List();
            return View(educations);
        }

        [HttpGet]
        public ActionResult AddEducation()
        {
            return View();
        }

        [HttpPost]

        public ActionResult AddEducation(TblEducation education)
        {
            if(ModelState.IsValid)
            {
                repo.TAdd(education);
                return RedirectToAction("Index");
            }
            else
            {
                return View("AddEducation");
            }
        }

        public ActionResult DeleteEducation(int id)
        {
            TblEducation education = repo.Find(x => x.id == id);

            if(education != null)
            {
                repo.TRemove(education);
                return RedirectToAction("Index");
            }
            else
            {
                return HttpNotFound();
            }
        }

        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            TblEducation education = repo.Find(x => x.id == id);
            if (education != null)
            {
                return View(education);
            }
            else
            {
                return HttpNotFound();
            }
        }

        [HttpPost]
        public ActionResult UpdateEducation(TblEducation edu)
        {
            if (ModelState.IsValid)
            {
                TblEducation education = repo.Find(x => x.id == edu.id);

                education.title = edu.title;
                education.subtitle = edu.subtitle;
                education.department = edu.department;
                education.gpa = edu.gpa;
                education.date = edu.date;

                repo.TUpdate(education);

                return RedirectToAction("Index");
            } else
            {
                return View("UpdateEducation");
            };
        }
	}
}