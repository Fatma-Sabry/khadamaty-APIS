using Khadamaty.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khadamaty.BL.Models
{
  public  class RatingVM
    {
        public int Id { get; set; }
     //   [MaxLength(10, ErrorMessage = "Rate From 10")]
        public int Rate { get; set; }

        public int ProjectId { get; set; }
      
        public Project Project { get; set; }

        public int ClientId { get; set; }
        
        public Client Client { get; set; }

        public int FreelanceId { get; set; }    
        public Freelance Freelance { get; set; }
    }
}
