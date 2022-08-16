using Khadamaty.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khadamaty.BL.Interface
{
   public interface IOfferRep
    {
        public IEnumerable<Offer> Get();
        public Offer GetByID(int ID);
        public Offer Create(Offer model);
        public Offer Update(Offer model);
        public void Delete(Offer model);
    }
}
