using MvcCvProject.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCvProject.Repositories
{
	public class ExperienceRepository : GenericRepository<TblExperiences>
	{
		DbCvEntities2 db = new DbCvEntities2();
		public List<TblExperiences> List()
		{
			return db.TblExperiences.ToList();
		}
	}
}