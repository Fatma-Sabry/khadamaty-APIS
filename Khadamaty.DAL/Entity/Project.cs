using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khadamaty.DAL.Entity
{
   public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Discribtion { get; set; }
        public DateTime CreationDate { get; set; }
        public string PhotoName { get; set; }
        public string FileName { get; set; }
        public bool IsActive { get; set; }
        public  virtual ICollection<Offer> offers { get; set; }
        public virtual ICollection<ProjectSkill> ProjectSkills { get; set; }
        public virtual Rating Rating { get; set; }
        public virtual Client Client { get; set; }
        public virtual Freelance Freelance { get; set; }
        public Project()
        {
            offers = new HashSet<Offer>();
            ProjectSkills = new HashSet<ProjectSkill>();
        }
    }
}
