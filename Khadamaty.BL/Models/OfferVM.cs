using Khadamaty.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khadamaty.BL.Models
{
  public  class OfferVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title Is Required")]
        [MaxLength(50, ErrorMessage = "The Max Length is 50")]
        [MinLength(10, ErrorMessage = "The Min Length is 10")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Discribtion Is Required")]
        [MinLength(20, ErrorMessage = "The Min Length is 10")]
        public string Discribtion { get; set; }
        public int ProjectID { get; set; }
        public Project Project { get; set; }
        public Client Client { get; set; }
        public Freelance Freelance { get; set; }
    }
}
