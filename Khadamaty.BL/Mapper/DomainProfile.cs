using AutoMapper;
using Khadamaty.BL.Models;
using Khadamaty.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khadamaty.BL.Mapper
{
  public  class DomainProfile: Profile
    {
        public DomainProfile()
       
        {
            CreateMap<Project, ProjectVM>(); 
            CreateMap<ProjectVM,Project>();

            CreateMap<Offer, OfferVM>();
            CreateMap<OfferVM, Offer>();

            CreateMap<ProjectSkill, ProjectSkillVM>();
            CreateMap<ProjectSkillVM, ProjectSkill>();

            CreateMap<Skill, SkillVM>();
            CreateMap<SkillVM, Skill>();

            CreateMap<Client,ClientVM>();
            CreateMap<ClientVM, Client>();

            CreateMap<Freelance, FreelanceVM>();
            CreateMap<FreelanceVM, Freelance>();

            CreateMap<ClientFreelance, ClientFreelanceVM>();
            CreateMap<ClientFreelanceVM, ClientFreelance>();

            CreateMap<Rating, RatingVM>();
            CreateMap<RatingVM, Rating>();

     
        }
           
    }
}
