using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khadamaty.DAL.Entity
{
   public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ProjectSkill> ProjectSkills { get; set; }
        public Skill()
        {
            ProjectSkills = new HashSet<ProjectSkill>();
        }
    }
}
