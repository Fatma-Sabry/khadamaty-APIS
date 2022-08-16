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
    public class ClientRep : IClientRep
    {

        private readonly KhadamatyContext db;

        public ClientRep(KhadamatyContext db)
        {
            this.db = db;
        }
        public Client Create(Client model)
        {
            db.Client.Add(model);
            db.SaveChanges();
            return db.Client.OrderBy(a => a.Id).LastOrDefault();
        }

        public void Delete(Client model)
        {
            db.Client.Remove(model);
            db.SaveChanges();
        }

        public IEnumerable<Client> Get()
        {
            var data = db.Client.Select(a => a);
            //Include("Project").Include("Offer").
            return data;
        }

        public Client GetByID(int ID)
        {
            var data = db.Client.Where(a => a.Id == ID).FirstOrDefault();
            //Include("Project").Include("Offer").
            return data;
        }

        public Client Update(Client model)
        {
            db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return db.Client.Find(model.Id);
        }
    }
}
