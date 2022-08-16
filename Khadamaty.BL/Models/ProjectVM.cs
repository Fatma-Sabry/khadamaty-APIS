using Khadamaty.DAL.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khadamaty.BL.Models
{
  public  class ProjectVM
    {
        public ProjectVM()
        {
            CreationDate = DateTime.Now;
            IsActive = true;
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Title Is Required")]
        [MaxLength(50, ErrorMessage = "The Max Length is 50")]
        [MinLength(10, ErrorMessage = "The Min Length is 10")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Discribtion Is Required")]
        [MinLength(20, ErrorMessage = "The Min Length is 10")]
        public string Discribtion { get; set; }
        public DateTime CreationDate { get; set; }
        public string PhotoName { get; set; }
        public string FileName { get; set; }
        public IFormFile Photo { get; set; }
        public IFormFile File { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Offer> offers { get; set; }
        public virtual ICollection<ProjectSkill> ProjectSkills { get; set; }
        public virtual Rating Rating { get; set; }
        public virtual Client Client { get; set; }
        public virtual Freelance Freelance { get; set; }
    }
}
