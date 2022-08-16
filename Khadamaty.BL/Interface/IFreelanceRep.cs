using Khadamaty.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khadamaty.BL.Interface
{
   public interface IFreelanceRep
    {
        public IEnumerable<Freelance> Get();
        public Freelance GetByID(int ID);
        public Freelance Create(Freelance model);
        public Freelance Update(Freelance model);
        public void Delete(Freelance model);
    }
}
