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
  public  class FreelanceRep:IFreelanceRep
    {

        private readonly KhadamatyContext db;

        public FreelanceRep(KhadamatyContext db)
        {
            this.db = db;
        }
        public Freelance Create(Freelance model)
        {
            db.Freelance.Add(model);
            db.SaveChanges();
            return db.Freelance.OrderBy(a => a.Id).LastOrDefault();
        }

        public void Delete(Freelance model)
        {
            db.Freelance.Remove(model);
            db.SaveChanges();
        }

        public IEnumerable<Freelance> Get()
        {
            var data = db.Freelance.Select(a => a);
            return data;
            //Include("Project").Include("Offer").
        }

        public Freelance GetByID(int ID)
        {
            var data = db.Freelance.Where(a => a.Id == ID).FirstOrDefault();
            return data;
            //Include("Project").Include("Offer").
        }

        public Freelance Update(Freelance model)
        {
            db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return db.Freelance.Find(model.Id);
        }
    }
}
