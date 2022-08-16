using Khadamaty.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khadamaty.BL.Interface
{
   public interface IProjectRep
    {
        public IEnumerable<Project> Get();
        public Project GetByID(int ID);
        public Project Create(Project model);
        public Project Update(Project model);
        public void Delete(Project model);
    }
}
