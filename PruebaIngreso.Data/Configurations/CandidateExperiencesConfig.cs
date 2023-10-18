using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PruebaIngreso.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngreso.Data.Configurations
{
    public class CandidateExperiencesConfig : IEntityTypeConfiguration<CandidateExperiences>
    {
      

        public void Configure(EntityTypeBuilder<CandidateExperiences> builder)
        {
            builder.Property(pro => pro.BeginDate).HasColumnType("date");
            builder.Property(pro => pro.EndDate).HasColumnType("date");
            builder.Property(pro => pro.InsertDate).HasColumnType("date");
            builder.Property(pro => pro.ModifyDate).HasColumnType("date");

            builder.HasKey(pro => pro.Id);

            builder.Property(p=>p.Company)
                   .HasMaxLength(100);

            builder.Property(p => p.Job)
                  .HasMaxLength(100);

            builder.Property(p => p.Description)
                  .HasMaxLength(4000);

            builder.Property(p => p.Salary)
                   .HasPrecision(8, 2);



        }
    }
}
