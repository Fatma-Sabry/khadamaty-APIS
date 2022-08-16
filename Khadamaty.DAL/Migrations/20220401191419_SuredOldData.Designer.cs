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
    [Migration("20220401191419_SuredOldData")]
    partial class SuredOldData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("Khadamaty.DAL.Entity.Project", b =>
                {
                    b.Navigation("offers");

                    b.Navigation("ProjectSkills");
                });

            modelBuilder.Entity("Khadamaty.DAL.Entity.Skill", b =>
                {
                    b.Navigation("ProjectSkills");
                });
#pragma warning restore 612, 618
        }
    }
}