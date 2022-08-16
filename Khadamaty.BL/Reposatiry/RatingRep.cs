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
    public class RatingRep : IRatingRep
    {
        private readonly KhadamatyContext db;

        public RatingRep(KhadamatyContext db)
        {
            this.db = db;
        }
        public Rating Create(Rating model)
        {
            db.Rating.Add(model);
            db.SaveChanges();
            return db.Rating.OrderBy(a => a.Id).LastOrDefault();
        }

        public void Delete(Rating model)
        {
            db.Rating.Remove(model);
            db.SaveChanges();
        }

        public IEnumerable<Rating> Get()
        {
            var data = db.Rating.Select(a => a);
            return data;
            //.Include("Project").Include("Freelancecs").Include("Client")
        }

        public Rating GetByID(int ID)
        {
            
            var data = db.Rating.Where(a => a.Id == ID).FirstOrDefault();
            
            //.Include("Project").Include("Freelancecs").Include("Client")
            return data;
        }

        public Rating Update(Rating model)
        {
            db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return db.Rating.Find(model.Id);
        }
    }
}
