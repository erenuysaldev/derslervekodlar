using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class InvitationParticipant
{
    public int Id { get; set; }
    public int InvitationId { get; set; }
    public Invitation Invitation { get; set; }
    public int ParticipantId { get; set; }
    public Participant Participant { get; set; }
}

public class Invitation
{
    public int Id { get; set; }
    public string EventName { get; set; }
    public DateTime EventDate { get; set; }
}

public class Participant
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public int NumberOfPeople { get; set; }
    public string PhoneNumber { get; set; }
}

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Invitation> Invitations { get; set; }
    public DbSet<Participant> Participants { get; set; }
    public DbSet<InvitationParticipant> InvitationParticipants { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region InvitationsHasData
        var invitations = new List<Invitation>
        {
            new Invitation { Id = 1, EventName = "Noel Partisi", EventDate = new DateTime(2024, 12, 25) },
            new Invitation { Id = 2, EventName = "Doğum Günü Partisi", EventDate = new DateTime(2024, 12, 12) }
        };
        modelBuilder.Entity<Invitation>().HasData(invitations);
        #endregion

        #region ParticipantHasData
        var participants = new List<Participant>
        {
            new Participant { Id = 1, FullName = "Eren", Age = 18, Email = "eren@business.com", NumberOfPeople = 1, PhoneNumber = "123123123" },
            new Participant { Id = 2, FullName = "Elif", Age = 22, Email = "elif@example.com", NumberOfPeople = 2, PhoneNumber = "456456456" },
            new Participant { Id = 3, FullName = "Ahmet", Age = 30, Email = "ahmet@workmail.com", NumberOfPeople = 3, PhoneNumber = "789789789" },
            new Participant { Id = 4, FullName = "Ayse", Age = 25, Email = "ayse@gmail.com", NumberOfPeople = 2, PhoneNumber = "111222333" },
            new Participant { Id = 5, FullName = "Mert", Age = 28, Email = "mert@corporate.com", NumberOfPeople = 4, PhoneNumber = "222333444" },
            new Participant { Id = 6, FullName = "Zeynep", Age = 35, Email = "zeynep@yahoo.com", NumberOfPeople = 1, PhoneNumber = "333444555" },
            new Participant { Id = 7, FullName = "Emre", Age = 40, Email = "emre@hotmail.com", NumberOfPeople = 5, PhoneNumber = "444555666" },
            new Participant { Id = 8, FullName = "Selin", Age = 19, Email = "selin@mail.com", NumberOfPeople = 2, PhoneNumber = "555666777" },
            new Participant { Id = 9, FullName = "Bora", Age = 27, Email = "bora@company.com", NumberOfPeople = 3, PhoneNumber = "666777888" },
            new Participant { Id = 10, FullName = "Deniz", Age = 32, Email = "deniz@business.org", NumberOfPeople = 1, PhoneNumber = "777888999" }
        };
        modelBuilder.Entity<Participant>().HasData(participants);
        #endregion

        #region InvitationParticipantHasData
        var invitationParticipants = new List<InvitationParticipant>
        {
            new InvitationParticipant { Id = 1, InvitationId = 1, ParticipantId = 1 },
            new InvitationParticipant { Id = 2, InvitationId = 1, ParticipantId = 2 },
            new InvitationParticipant { Id = 3, InvitationId = 1, ParticipantId = 3 },
            new InvitationParticipant { Id = 4, InvitationId = 1, ParticipantId = 4 },
            new InvitationParticipant { Id = 5, InvitationId = 1, ParticipantId = 5 },
            new InvitationParticipant { Id = 6, InvitationId = 1, ParticipantId = 6 },
            new InvitationParticipant { Id = 7, InvitationId = 1, ParticipantId = 7 },
            new InvitationParticipant { Id = 8, InvitationId = 1, ParticipantId = 8 },
            new InvitationParticipant { Id = 9, InvitationId = 1, ParticipantId = 9 },
            new InvitationParticipant { Id = 10, InvitationId = 2, ParticipantId = 1 },
            new InvitationParticipant { Id = 11, InvitationId = 2, ParticipantId = 2 },
            new InvitationParticipant { Id = 12, InvitationId = 2, ParticipantId = 3 },
            new InvitationParticipant { Id = 13, InvitationId = 2, ParticipantId = 4 },
            new InvitationParticipant { Id = 14, InvitationId = 2, ParticipantId = 5 },
            new InvitationParticipant { Id = 15, InvitationId = 2, ParticipantId = 6 },
            new InvitationParticipant { Id = 16, InvitationId = 2, ParticipantId = 7 },
            new InvitationParticipant { Id = 17, InvitationId = 2, ParticipantId = 8 },
            new InvitationParticipant { Id = 18, InvitationId = 2, ParticipantId = 9 },
            new InvitationParticipant { Id = 19, InvitationId = 2, ParticipantId = 10 }
        };
        modelBuilder.Entity<InvitationParticipant>().HasData(invitationParticipants);
        #endregion

        base.OnModelCreating(modelBuilder);
    }
}
