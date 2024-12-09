﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PartyApp.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241206080307_SampleOtherData")]
    partial class SampleOtherData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Invitation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Invitations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EventDate = new DateTime(2024, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventName = "Noel Partisi"
                        },
                        new
                        {
                            Id = 2,
                            EventDate = new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventName = "Doğum Günü Partisi"
                        });
                });

            modelBuilder.Entity("InvitationParticipant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("InvitationId")
                        .HasColumnType("int");

                    b.Property<int>("ParticipantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InvitationId");

                    b.HasIndex("ParticipantId");

                    b.ToTable("InvitationParticipants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            InvitationId = 1,
                            ParticipantId = 1
                        },
                        new
                        {
                            Id = 2,
                            InvitationId = 1,
                            ParticipantId = 2
                        },
                        new
                        {
                            Id = 3,
                            InvitationId = 1,
                            ParticipantId = 3
                        },
                        new
                        {
                            Id = 4,
                            InvitationId = 1,
                            ParticipantId = 4
                        },
                        new
                        {
                            Id = 5,
                            InvitationId = 1,
                            ParticipantId = 5
                        },
                        new
                        {
                            Id = 6,
                            InvitationId = 1,
                            ParticipantId = 6
                        },
                        new
                        {
                            Id = 7,
                            InvitationId = 1,
                            ParticipantId = 7
                        },
                        new
                        {
                            Id = 8,
                            InvitationId = 1,
                            ParticipantId = 8
                        },
                        new
                        {
                            Id = 9,
                            InvitationId = 1,
                            ParticipantId = 9
                        },
                        new
                        {
                            Id = 10,
                            InvitationId = 2,
                            ParticipantId = 1
                        },
                        new
                        {
                            Id = 11,
                            InvitationId = 2,
                            ParticipantId = 2
                        },
                        new
                        {
                            Id = 12,
                            InvitationId = 2,
                            ParticipantId = 3
                        },
                        new
                        {
                            Id = 13,
                            InvitationId = 2,
                            ParticipantId = 4
                        },
                        new
                        {
                            Id = 14,
                            InvitationId = 2,
                            ParticipantId = 5
                        },
                        new
                        {
                            Id = 15,
                            InvitationId = 2,
                            ParticipantId = 6
                        },
                        new
                        {
                            Id = 16,
                            InvitationId = 2,
                            ParticipantId = 7
                        },
                        new
                        {
                            Id = 17,
                            InvitationId = 2,
                            ParticipantId = 8
                        },
                        new
                        {
                            Id = 18,
                            InvitationId = 2,
                            ParticipantId = 9
                        },
                        new
                        {
                            Id = 19,
                            InvitationId = 2,
                            ParticipantId = 10
                        });
                });

            modelBuilder.Entity("Participant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfPeople")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Participants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 18,
                            Email = "eren@business.com",
                            FullName = "Eren",
                            NumberOfPeople = 1,
                            PhoneNumber = "123123123"
                        },
                        new
                        {
                            Id = 2,
                            Age = 22,
                            Email = "elif@example.com",
                            FullName = "Elif",
                            NumberOfPeople = 2,
                            PhoneNumber = "456456456"
                        },
                        new
                        {
                            Id = 3,
                            Age = 30,
                            Email = "ahmet@workmail.com",
                            FullName = "Ahmet",
                            NumberOfPeople = 3,
                            PhoneNumber = "789789789"
                        },
                        new
                        {
                            Id = 4,
                            Age = 25,
                            Email = "ayse@gmail.com",
                            FullName = "Ayse",
                            NumberOfPeople = 2,
                            PhoneNumber = "111222333"
                        },
                        new
                        {
                            Id = 5,
                            Age = 28,
                            Email = "mert@corporate.com",
                            FullName = "Mert",
                            NumberOfPeople = 4,
                            PhoneNumber = "222333444"
                        },
                        new
                        {
                            Id = 6,
                            Age = 35,
                            Email = "zeynep@yahoo.com",
                            FullName = "Zeynep",
                            NumberOfPeople = 1,
                            PhoneNumber = "333444555"
                        },
                        new
                        {
                            Id = 7,
                            Age = 40,
                            Email = "emre@hotmail.com",
                            FullName = "Emre",
                            NumberOfPeople = 5,
                            PhoneNumber = "444555666"
                        },
                        new
                        {
                            Id = 8,
                            Age = 19,
                            Email = "selin@mail.com",
                            FullName = "Selin",
                            NumberOfPeople = 2,
                            PhoneNumber = "555666777"
                        },
                        new
                        {
                            Id = 9,
                            Age = 27,
                            Email = "bora@company.com",
                            FullName = "Bora",
                            NumberOfPeople = 3,
                            PhoneNumber = "666777888"
                        },
                        new
                        {
                            Id = 10,
                            Age = 32,
                            Email = "deniz@business.org",
                            FullName = "Deniz",
                            NumberOfPeople = 1,
                            PhoneNumber = "777888999"
                        });
                });

            modelBuilder.Entity("InvitationParticipant", b =>
                {
                    b.HasOne("Invitation", "Invitation")
                        .WithMany()
                        .HasForeignKey("InvitationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Participant", "Participant")
                        .WithMany()
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invitation");

                    b.Navigation("Participant");
                });
#pragma warning restore 612, 618
        }
    }
}
