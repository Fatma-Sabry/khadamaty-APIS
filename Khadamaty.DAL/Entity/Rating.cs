using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khadamaty.DAL.Entity
{
   public class Rating
    {

        public int Id { get; set; }
        public int Rate { get; set; }

        public int ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        public Project Project { get; set; }

        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }

        public int FreelanceId { get; set; }
        [ForeignKey("FreelanceId")]
        public Freelance Freelance { get; set; }
    }
}
