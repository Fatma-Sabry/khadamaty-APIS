﻿// <auto-generated />
using System;
using Khadamaty.DAL.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Khadamaty.DAL.Migrations
{
    [DbContext(typeof(KhadamatyContext))]
    [Migration("20220403020120_UpdateData")]
    partial class UpdateData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Khadamaty.DAL.Entity.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OfferId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfferId")
                        .IsUnique();

                    b.HasIndex("ProjectId")
                        .IsUnique();

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Khadamaty.DAL.Entity.ClientFreelance", b =>
                {
                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<int>("FreelanceID")
                        .HasColumnType("int");

                    b.HasKey("ClientID", "FreelanceID");

                    b.HasIndex("FreelanceID");

                    b.ToTable("ClientFreelance");
                });

            modelBuilder.Entity("Khadamaty.DAL.Entity.Freelance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OfferId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfferId")
                        .IsUnique();

                    b.HasIndex("ProjectId")
                        .IsUnique();

                    b.ToTable("Freelance");
                });

            modelBuilder.Entity("Khadamaty.DAL.Entity.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discribtion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Offer");
                });

            modelBuilder.Entity("Khadamaty.DAL.Entity.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discribtion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PhotoName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("Khadamaty.DAL.Entity.ProjectSkill", b =>
                {
                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("ProjectId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("ProjectSkill");
                });

            modelBuilder.Entity("Khadamaty.DAL.Entity.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("FreelanceId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("FreelanceId");

                    b.HasIndex("ProjectId")
                        .IsUnique();

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("Khadamaty.DAL.Entity.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("Khadamaty.DAL.Entity.Client", b =>
                {
                    b.HasOne("Khadamaty.DAL.Entity.Offer", "Offer")
                        .WithOne("Client")
                        .HasForeignKey("Khadamaty.DAL.Entity.Client", "OfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Khadamaty.DAL.Entity.Project", "Project")
                        .WithOne("Client")
                        .HasForeignKey("Khadamaty.DAL.Entity.Client", "ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Offer");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Khadamaty.DAL.Entity.ClientFreelance", b =>
                {
                    b.HasOne("Khadamaty.DAL.Entity.Client", null)
                        .WithMany("Freelances")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Khadamaty.DAL.Entity.Freelance", null)
                        .WithMany("clients")
                        .HasForeignKey("FreelanceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Khadamaty.DAL.Entity.Freelance", b =>
                {
                    b.HasOne("Khadamaty.DAL.Entity.Offer", "Offer")
                        .WithOne("Freelance")
                        .HasForeignKey("Khadamaty.DAL.Entity.Freelance", "OfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Khadamaty.DAL.Entity.Project", "Project")
                        .WithOne("Freelance")
                        .HasForeignKey("Khadamaty.DAL.Entity.Freelance", "ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Offer");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Khadamaty.DAL.Entity.Offer", b =>
                {
                    b.HasOne("Khadamaty.DAL.Entity.Project", "Project")
                        .WithMany("offers")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Khadamaty.DAL.Entity.ProjectSkill", b =>
                {
                    b.HasOne("Khadamaty.DAL.Entity.Project", null)
                        .WithMany("ProjectSkills")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Khadamaty.DAL.Entity.Skill", null)
                        .WithMany("ProjectSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Khadamaty.DAL.Entity.Rating", b =>
                {
                    b.HasOne("Khadamaty.DAL.Entity.Client", "Client")
                        .WithMany("Ratings")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Khadamaty.DAL.Entity.Freelance", "Freelance")
                        .WithMany("Ratings")
                        .HasForeignKey("FreelanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Khadamaty.DAL.Entity.Project", "Project")
                        .WithOne("Rating")
                        .HasForeignKey("Khadamaty.DAL.Entity.Rating", "ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Freelance");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Khadamaty.DAL.Entity.Client", b =>
                {
                    b.Navigation("Freelances");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("Khadamaty.DAL.Entity.Freelance", b =>
                {
                    b.Navigation("clients");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("Khadamaty.DAL.Entity.Offer", b =>
                {
                    b.Navigation("Client");

                    b.Navigation("Freelance");
                });

            modelBuilder.Entity("Khadamaty.DAL.Entity.Project", b =>
                {
                    b.Navigation("Client");

                    b.Navigation("Freelance");

                    b.Navigation("offers");

                    b.Navigation("ProjectSkills");

                    b.Navigation("Rating");
                });

            modelBuilder.Entity("Khadamaty.DAL.Entity.Skill", b =>
                {
                    b.Navigation("ProjectSkills");
                });
#pragma warning restore 612, 618
        }
    }
}
