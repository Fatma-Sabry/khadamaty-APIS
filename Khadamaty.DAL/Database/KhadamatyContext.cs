using Khadamaty.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khadamaty.DAL.Database
{
   public  class KhadamatyContext: DbContext
    {
        public KhadamatyContext(DbContextOptions<KhadamatyContext> options):base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<ProjectSkill>().HasKey(PS=>new {PS.ProjectId,PS.SkillId });

            modelBuilder.Entity<ClientFreelance>().HasKey(CF => new { CF.ClientID, CF.FreelanceID });
        }
        public DbSet<Project> Project { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Offer> Offer { get; set; }
        public DbSet<ProjectSkill> ProjectSkill { get; set; }
  
        public DbSet<Rating> Rating { get; set; }
        public DbSet<Client> Client { get; set; }

        public DbSet<Freelance> Freelance { get; set; }
        public DbSet<ClientFreelance> ClientFreelance { get; set; }

    }
}
