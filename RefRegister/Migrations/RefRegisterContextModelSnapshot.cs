﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RefRegister.Models;

namespace RefRegister.Migrations
{
    [DbContext(typeof(RefRegisterContext))]
    partial class RefRegisterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RefRegister.Models.Arena", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("ContactName");

                    b.Property<string>("Email");

                    b.Property<int?>("MatchId");

                    b.Property<string>("Name");

                    b.Property<string>("Phonenumber");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.ToTable("Arena");
                });

            modelBuilder.Entity("RefRegister.Models.Domarlista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BirthDate");

                    b.Property<string>("Category");

                    b.Property<string>("CategoryType");

                    b.Property<string>("Club");

                    b.Property<string>("County");

                    b.Property<string>("Created");

                    b.Property<string>("Distrikt");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Payed");

                    b.Property<string>("Phone1");

                    b.Property<string>("Phone2");

                    b.Property<string>("RefNumber");

                    b.Property<string>("RefType");

                    b.Property<string>("Registred");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("Zipcode");

                    b.HasKey("Id");

                    b.ToTable("Domarlista");
                });

            modelBuilder.Entity("RefRegister.Models.Fee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<int?>("MatchId");

                    b.Property<int?>("MatchId1");

                    b.Property<int?>("MatchId2");

                    b.Property<int?>("MatchId3");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("MatchId1");

                    b.HasIndex("MatchId2");

                    b.HasIndex("MatchId3");

                    b.ToTable("Fee");
                });

            modelBuilder.Entity("RefRegister.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Arena");

                    b.Property<string>("Fee1");

                    b.Property<string>("Fee2");

                    b.Property<string>("Fee3");

                    b.Property<string>("Fee4");

                    b.Property<string>("GameDate");

                    b.Property<string>("MatchNumber");

                    b.Property<string>("Ref1");

                    b.Property<string>("Ref2");

                    b.Property<string>("Ref3");

                    b.Property<string>("Ref4");

                    b.Property<string>("Score1");

                    b.Property<string>("Score2");

                    b.Property<string>("Team1");

                    b.Property<string>("Team2");

                    b.HasKey("Id");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("RefRegister.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("GameDate");

                    b.Property<int>("MatchNumber");

                    b.Property<int>("Score1");

                    b.Property<int>("Score2");

                    b.HasKey("Id");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("RefRegister.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BirthDate");

                    b.Property<string>("County");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone1");

                    b.Property<string>("Phone2");

                    b.Property<string>("RefNumber");

                    b.Property<string>("StaffType");

                    b.Property<string>("StreetAddress");

                    b.Property<int?>("TeamId");

                    b.Property<int?>("TeamId1");

                    b.Property<int?>("TeamId2");

                    b.Property<int?>("TeamId3");

                    b.Property<int?>("TeamId4");

                    b.Property<string>("Zipcode");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.HasIndex("TeamId1");

                    b.HasIndex("TeamId2");

                    b.HasIndex("TeamId3");

                    b.HasIndex("TeamId4");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("RefRegister.Models.Referee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int?>("MatchId");

                    b.Property<int?>("MatchId1");

                    b.Property<int?>("MatchId2");

                    b.Property<int?>("MatchId3");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("RefNumber");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("MatchId1");

                    b.HasIndex("MatchId2");

                    b.HasIndex("MatchId3");

                    b.ToTable("Referee");
                });

            modelBuilder.Entity("RefRegister.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("ContactName");

                    b.Property<string>("Email");

                    b.Property<int?>("MatchId");

                    b.Property<int?>("MatchId1");

                    b.Property<string>("Name");

                    b.Property<string>("Phonenumber");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("MatchId1");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("RefRegister.Models.Arena", b =>
                {
                    b.HasOne("RefRegister.Models.Match")
                        .WithMany("Arena")
                        .HasForeignKey("MatchId");
                });

            modelBuilder.Entity("RefRegister.Models.Fee", b =>
                {
                    b.HasOne("RefRegister.Models.Match")
                        .WithMany("Fee1")
                        .HasForeignKey("MatchId");

                    b.HasOne("RefRegister.Models.Match")
                        .WithMany("Fee2")
                        .HasForeignKey("MatchId1");

                    b.HasOne("RefRegister.Models.Match")
                        .WithMany("Fee3")
                        .HasForeignKey("MatchId2");

                    b.HasOne("RefRegister.Models.Match")
                        .WithMany("Fee4")
                        .HasForeignKey("MatchId3");
                });

            modelBuilder.Entity("RefRegister.Models.Person", b =>
                {
                    b.HasOne("RefRegister.Models.Team")
                        .WithMany("Staff1")
                        .HasForeignKey("TeamId");

                    b.HasOne("RefRegister.Models.Team")
                        .WithMany("Staff2")
                        .HasForeignKey("TeamId1");

                    b.HasOne("RefRegister.Models.Team")
                        .WithMany("Staff3")
                        .HasForeignKey("TeamId2");

                    b.HasOne("RefRegister.Models.Team")
                        .WithMany("Staff4")
                        .HasForeignKey("TeamId3");

                    b.HasOne("RefRegister.Models.Team")
                        .WithMany("Staff5")
                        .HasForeignKey("TeamId4");
                });

            modelBuilder.Entity("RefRegister.Models.Referee", b =>
                {
                    b.HasOne("RefRegister.Models.Match")
                        .WithMany("Ref1")
                        .HasForeignKey("MatchId");

                    b.HasOne("RefRegister.Models.Match")
                        .WithMany("Ref2")
                        .HasForeignKey("MatchId1");

                    b.HasOne("RefRegister.Models.Match")
                        .WithMany("Ref3")
                        .HasForeignKey("MatchId2");

                    b.HasOne("RefRegister.Models.Match")
                        .WithMany("Ref4")
                        .HasForeignKey("MatchId3");
                });

            modelBuilder.Entity("RefRegister.Models.Team", b =>
                {
                    b.HasOne("RefRegister.Models.Match")
                        .WithMany("Team1")
                        .HasForeignKey("MatchId");

                    b.HasOne("RefRegister.Models.Match")
                        .WithMany("Team2")
                        .HasForeignKey("MatchId1");
                });
#pragma warning restore 612, 618
        }
    }
}
