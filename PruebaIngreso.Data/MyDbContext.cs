using Microsoft.EntityFrameworkCore;
using PruebaIngreso.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngreso.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Candidate>().Property(p=> p.InsertDate).HasColumnType("date");
            modelBuilder.Entity<Candidate>().Property(p=> p.BirthDate).HasColumnType("date");
            modelBuilder.Entity<Candidate>().Property(p=> p.ModifyDate).HasColumnType("date");

        }


        public DbSet<Candidate> Candidates { get; set; }

        public DbSet<CandidateExperiences> CandidateExperiences { get; set; }
    }
}
