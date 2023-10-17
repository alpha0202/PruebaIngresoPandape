using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace PruebaIngreso.Entities.Configurations
{
    internal class CandidateConfg : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {
            builder.Property(pro => pro.InsertDate).HasColumnType("date");
            builder.Property(pro => pro.BirthDate).HasColumnType("date");
            builder.Property(pro => pro.ModifyDate).HasColumnType("date");
        }
    }
}
