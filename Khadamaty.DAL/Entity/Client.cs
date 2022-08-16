using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khadamaty.DAL.Entity
{
   public class Client
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public ICollection<Rating> Ratings { get; set; }

        public ICollection<ClientFreelance> Freelances { get; set; }

        public int? OfferId { get; set; }
        [ForeignKey("OfferId")]
        public Offer Offer { get; set; }
        public int? ProjectId { get; set; }
        public Project Project { get; set; }

      
    }
}
