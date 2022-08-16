using Khadamaty.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khadamaty.BL.Models
{
 public   class FreelanceVM
    {
        public int Id { get; set; }
        [EmailAddress(ErrorMessage = "Mail  not Valid")]
        public string Email { get; set; }
        public string Name { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public ICollection<ClientFreelance> clients { get; set; }
        public int? OfferId { get; set; }
        public Offer Offer { get; set; }
        public int? ProjectId { get; set; }
        public Project Project { get; set; }

    }
}
