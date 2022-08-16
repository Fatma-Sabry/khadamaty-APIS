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
  public  class OfferRep: IOfferRep
    {
        private readonly KhadamatyContext db;

        public OfferRep(KhadamatyContext db)
        {
            this.db = db;
        }
        public Offer Create(Offer model)
        {
            db.Offer.Add(model);
            db.SaveChanges();
            return db.Offer.OrderBy(a => a.Id).LastOrDefault();
        }

        public void Delete(Offer model)
        {
            db.Offer.Remove(model);
            db.SaveChanges();
        }

        public IEnumerable<Offer> Get()
        {
            var data = db.Offer.Include("Project").Select(a => a);
            return data;
        }

        public Offer GetByID(int ID)
        {
            var data = db.Offer.Include("Project").Where(a => a.Id == ID).FirstOrDefault();
            return data;
        }

        public Offer Update(Offer model)
        {
            db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return db.Offer.Find(model.Id);
        }
    }
}
