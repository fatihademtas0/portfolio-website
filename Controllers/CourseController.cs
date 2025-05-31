using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;

namespace MvcCvProject.Controllers
{
    public class CourseController : Controller
    {
        GenericRepository<TblCourses> repo = new GenericRepository<TblCourses>();

        public ActionResult Index()
        {
            var courses = repo.List();
            return View(courses);
        }

        [HttpGet]
        public ActionResult AddCourse()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCourse(TblCourses course)
        {
            if (ModelState.IsValid)
            {
                repo.TAdd(course);
                return RedirectToAction("Index");
            }
            else
            {
                return View("AddCourse");
            }
        }

        public ActionResult DeleteCourse(int id)
		{
			TblCourses course = repo.Find(x => x.id == id);
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
		public ActionResult UpdateCourse(int id)
		{
			TblCourses course = repo.Find(x => x.id == id);
			if(course != null)
			{
				return View(course);
			}else
			{
				return HttpNotFound();
			}
		}

		[HttpPost]
		public ActionResult UpdateCourse(TblCourses course)
		{
			if(course != null && ModelState.IsValid)
			{
				TblCourses cou = repo.Find(x => x.id == course.id);

				if (cou != null)
				{
					cou.description = course.description;
					repo.TUpdate(cou);
					return RedirectToAction("Index");
				}
				else
				{
					return RedirectToAction("UpdateCourse");
				}
			}else
			{
				return RedirectToAction("UpdateCourse");
			}
		}
	}
}