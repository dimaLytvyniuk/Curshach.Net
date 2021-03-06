﻿// <auto-generated />
using Labange.DAL.EF;
using Labange.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Labange.PL.Migrations
{
    [DbContext(typeof(LabangeContext))]
    [Migration("20180527160102_init-5.0")]
    partial class init50
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Labange.DAL.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("About");

                    b.Property<int>("BusinessArea");

                    b.Property<string>("City");

                    b.Property<string>("Name");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Labange.DAL.Entities.Resume", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("About");

                    b.Property<int>("ExperienceYears");

                    b.Property<string>("PlacesOfWork");

                    b.Property<int>("SkillCategory");

                    b.Property<string>("Skills");

                    b.Property<int>("UnemployedId");

                    b.HasKey("Id");

                    b.HasIndex("UnemployedId")
                        .IsUnique();

                    b.ToTable("Resumes");
                });

            modelBuilder.Entity("Labange.DAL.Entities.Unemployed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("City");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("ResumeId");

                    b.HasKey("Id");

                    b.ToTable("Unemployeds");
                });

            modelBuilder.Entity("Labange.DAL.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Labange.DAL.Entities.Vacation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyId");

                    b.Property<string>("Name");

                    b.Property<string>("Responsibilities");

                    b.Property<int>("Salary");

                    b.Property<int>("SkillCategory");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Vacations");
                });

            modelBuilder.Entity("Labange.DAL.Entities.Resume", b =>
                {
                    b.HasOne("Labange.DAL.Entities.Unemployed", "Unemployed")
                        .WithOne("Resume")
                        .HasForeignKey("Labange.DAL.Entities.Resume", "UnemployedId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Labange.DAL.Entities.Vacation", b =>
                {
                    b.HasOne("Labange.DAL.Entities.Company", "Company")
                        .WithMany("Vacations")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
