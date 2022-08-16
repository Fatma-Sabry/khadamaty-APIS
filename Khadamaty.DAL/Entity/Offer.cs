using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khadamaty.DAL.Entity
{
  public  class Offer
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Discribtion { get; set; }
        public int ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        public Project Project { get; set; }

        public Client Client { get; set; }
        public Freelance Freelance { get; set; }

    }
}
