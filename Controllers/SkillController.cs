using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;

namespace MvcCvProject.Controllers
{
    public class SkillController : Controller
    {
        GenericRepository<TblSkills> repo = new GenericRepository<TblSkills>();
		public ActionResult Index()
        {
            var skills = repo.List();
            return View(skills);
        }

		[HttpGet]
		public ActionResult AddSkill()
		{
			return View();
		}

		[HttpPost]
		public ActionResult AddSkill(TblSkills t)
		{
			repo.TAdd(t);
			return RedirectToAction("Index");
		}

		public ActionResult DeleteSkill(int id)
		{
			TblSkills skill = repo.Find(x => x.id == id);
			if (skill != null)
			{
				repo.TRemove(skill);
			}
			return RedirectToAction("Index");
		}

		[HttpGet]
		public ActionResult UpdateSkill(int id)
		{
			TblSkills skill = repo.Find(x => x.id == id);
			if(skill != null)
			{
				return View(skill);
			}
			else
			{
				return HttpNotFound("Skill not found!");
			}
		}

		[HttpPost]
		public ActionResult UpdateSkill(TblSkills t)
		{
			TblSkills skill = repo.Find(x => x.id == t.id);
			if(skill != null)
			{
				skill.skill = t.skill;
				skill.rate = t.rate;
				repo.TUpdate(skill);
				return RedirectToAction("Index");
			}else
			{
				return HttpNotFound("Skill not found!");
			}
		}
	}
}