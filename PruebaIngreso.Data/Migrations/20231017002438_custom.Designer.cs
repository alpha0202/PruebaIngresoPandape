﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaIngreso.Data;

#nullable disable

namespace PruebaIngreso.Data.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20231017002438_custom")]
    partial class custom
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("PruebaIngreso.Entities.CandidateExperiences", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BeginDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("CandidatoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Company")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdCandidate")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Job")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Salary")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoId");

                    b.ToTable("CandidateExperiences");
                });

            modelBuilder.Entity("PruebaIngreso.Entities.Candidates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("SurName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("PruebaIngreso.Entities.CandidateExperiences", b =>
                {
                    b.HasOne("PruebaIngreso.Entities.Candidates", "Candidato")
                        .WithMany("CandidateExperiences")
                        .HasForeignKey("CandidatoId");

                    b.Navigation("Candidato");
                });

            modelBuilder.Entity("PruebaIngreso.Entities.Candidates", b =>
                {
                    b.Navigation("CandidateExperiences");
                });
#pragma warning restore 612, 618
        }
    }
}
