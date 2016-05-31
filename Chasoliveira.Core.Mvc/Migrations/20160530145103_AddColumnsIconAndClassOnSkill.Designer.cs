using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Chasoliveira.Core.Data.Contexts;

namespace Chasoliveira.Core.Mvc.Migrations
{
    [DbContext(typeof(ChasoDBContext))]
    [Migration("20160530145103_AddColumnsIconAndClassOnSkill")]
    partial class AddColumnsIconAndClassOnSkill
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901");

            modelBuilder.Entity("Chasoliveira.Core.Domain.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Icon");

                    b.Property<int>("PersonId");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Chasoliveira.Core.Domain.Entities.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Company");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("Finished");

                    b.Property<int>("HistoryType");

                    b.Property<string>("Location");

                    b.Property<int>("PersonId");

                    b.Property<DateTime>("Start");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Histories");
                });

            modelBuilder.Entity("Chasoliveira.Core.Domain.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Occupation");

                    b.Property<string>("PersonStatment");

                    b.Property<string>("PhotoProfile");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Chasoliveira.Core.Domain.Entities.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Class");

                    b.Property<string>("Description");

                    b.Property<string>("Icon");

                    b.Property<int>("PersonId");

                    b.Property<decimal>("Progress");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Chasoliveira.Core.Domain.Entities.Social", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Icon");

                    b.Property<int>("PersonId");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Socials");
                });

            modelBuilder.Entity("Chasoliveira.Core.Domain.Entities.Token", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthToken");

                    b.Property<DateTime>("ExpiresOn");

                    b.Property<DateTime>("IssuedOn");

                    b.Property<DateTime>("LastSync");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("Chasoliveira.Core.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Password");

                    b.Property<int>("PersonId");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Chasoliveira.Core.Domain.Entities.Contact", b =>
                {
                    b.HasOne("Chasoliveira.Core.Domain.Entities.Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Chasoliveira.Core.Domain.Entities.History", b =>
                {
                    b.HasOne("Chasoliveira.Core.Domain.Entities.Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Chasoliveira.Core.Domain.Entities.Skill", b =>
                {
                    b.HasOne("Chasoliveira.Core.Domain.Entities.Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Chasoliveira.Core.Domain.Entities.Social", b =>
                {
                    b.HasOne("Chasoliveira.Core.Domain.Entities.Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Chasoliveira.Core.Domain.Entities.Token", b =>
                {
                    b.HasOne("Chasoliveira.Core.Domain.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Chasoliveira.Core.Domain.Entities.User", b =>
                {
                    b.HasOne("Chasoliveira.Core.Domain.Entities.Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
