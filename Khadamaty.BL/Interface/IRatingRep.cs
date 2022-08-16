using Khadamaty.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khadamaty.BL.Interface
{
   public interface IRatingRep
    {
        public IEnumerable<Rating> Get();
        public Rating GetByID(int ID);
        public Rating Create(Rating model);
        public Rating Update(Rating model);
        public void Delete(Rating model);
    }

}
