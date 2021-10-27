using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discussions.Areas.Identity.Data;
using Discussions.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Discussions.Data
{
    public class DiscussionsContext : IdentityDbContext<DiscussionsUser>
    {
        public DiscussionsContext(DbContextOptions<DiscussionsContext> options)
            : base(options)
        {
        }

        public DbSet<Communaute> Communaute { get; set; }
        public DbSet<AbonnementCommunaute> Abonnements { get; set; }
        public DbSet<Message> Message { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Communaute>().Property(e => e.CommunauteId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Communaute>().ToTable("Communautes");

            modelBuilder.Entity<Message>().ToTable("Messages");

            modelBuilder.Entity<AbonnementCommunaute>().HasKey((a) => new { a.DiscussionsUserId, a.CommunauteId });
            modelBuilder.Entity<Fil>().ToTable("Fils");
            modelBuilder.Entity<Reponse>().ToTable("Reponses").HasIndex(r => r.MessageOrigineId);

            modelBuilder.Entity<Communaute>()
                .HasData(
                new Communaute { CommunauteId = 1, Name = "Accueil", CreationDate = DateTime.UtcNow},
                new Communaute { CommunauteId = 2, Name = "Toulouse", CreationDate = DateTime.UtcNow },
                new Communaute { CommunauteId = 3, Name = "Sports", CreationDate = DateTime.UtcNow }
                );
        }
    }

}
