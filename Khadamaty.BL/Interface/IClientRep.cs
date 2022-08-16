using Khadamaty.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khadamaty.BL.Interface
{
   public interface IClientRep
    {
        public IEnumerable<Client> Get();
        public Client GetByID(int ID);
        public Client Create(Client model);
        public Client Update(Client model);
        public void Delete(Client model);
    }
}
