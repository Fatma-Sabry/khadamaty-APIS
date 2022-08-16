using Khadamaty.BL.Interface;
using Khadamaty.DAL.Database;
using Khadamaty.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khadamaty.BL.Reposatiry
{
    public class ProjectRep : IProjectRep
    {
        private readonly KhadamatyContext db;

        public ProjectRep(KhadamatyContext db)
        {
            this.db = db;
        }
        public Project Create(Project model)
        {
            db.Project.Add(model);
            db.SaveChanges();
            return db.Project.OrderBy(a=>a.Id).LastOrDefault();
        }

        public void Delete(Project model)
        {
            db.Project.Remove(model);
            db.SaveChanges();
        }

        public IEnumerable<Project> Get()
        {
            var data = db.Project.Include("ProjectSkills").Include("offers").Include("Rating").Select(a => a);
            return data;
        }

        public Project GetByID(int ID)
        {
            var data = db.Project.Include("ProjectSkills").Include("Rating").Include("offers").Where(a => a.Id == ID).FirstOrDefault();
            return data;
        }

        public Project Update(Project model)
        {
            db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return db.Project.Find(model.Id);
        }
    }
}
