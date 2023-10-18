using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PruebaIngreso.Entities;

namespace PruebaIngreso.Data.Configurations
{
    public class CandidateConfg : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {
            builder.Property(pro => pro.InsertDate).HasColumnType("date");
            builder.Property(pro => pro.BirthDate).HasColumnType("date");
            builder.Property(pro => pro.ModifyDate).HasColumnType("date");
            
            builder.HasKey(pro => pro.Id);
            
            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(p=> p.SurName)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(e=> e.Email)
                .HasColumnType("email")
                .HasMaxLength(250);
                
        }
    }
}
