using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PartyApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SampleOtherData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invitations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invitations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfPeople = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvitationParticipants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvitationId = table.Column<int>(type: "int", nullable: false),
                    ParticipantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvitationParticipants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvitationParticipants_Invitations_InvitationId",
                        column: x => x.InvitationId,
                        principalTable: "Invitations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvitationParticipants_Participants_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "Participants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Invitations",
                columns: new[] { "Id", "EventDate", "EventName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noel Partisi" },
                    { 2, new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doğum Günü Partisi" }
                });

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "Id", "Age", "Email", "FullName", "NumberOfPeople", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 18, "eren@business.com", "Eren", 1, "123123123" },
                    { 2, 22, "elif@example.com", "Elif", 2, "456456456" },
                    { 3, 30, "ahmet@workmail.com", "Ahmet", 3, "789789789" },
                    { 4, 25, "ayse@gmail.com", "Ayse", 2, "111222333" },
                    { 5, 28, "mert@corporate.com", "Mert", 4, "222333444" },
                    { 6, 35, "zeynep@yahoo.com", "Zeynep", 1, "333444555" },
                    { 7, 40, "emre@hotmail.com", "Emre", 5, "444555666" },
                    { 8, 19, "selin@mail.com", "Selin", 2, "555666777" },
                    { 9, 27, "bora@company.com", "Bora", 3, "666777888" },
                    { 10, 32, "deniz@business.org", "Deniz", 1, "777888999" }
                });

            migrationBuilder.InsertData(
                table: "InvitationParticipants",
                columns: new[] { "Id", "InvitationId", "ParticipantId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 6, 1, 6 },
                    { 7, 1, 7 },
                    { 8, 1, 8 },
                    { 9, 1, 9 },
                    { 10, 2, 1 },
                    { 11, 2, 2 },
                    { 12, 2, 3 },
                    { 13, 2, 4 },
                    { 14, 2, 5 },
                    { 15, 2, 6 },
                    { 16, 2, 7 },
                    { 17, 2, 8 },
                    { 18, 2, 9 },
                    { 19, 2, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvitationParticipants_InvitationId",
                table: "InvitationParticipants",
                column: "InvitationId");

            migrationBuilder.CreateIndex(
                name: "IX_InvitationParticipants_ParticipantId",
                table: "InvitationParticipants",
                column: "ParticipantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvitationParticipants");

            migrationBuilder.DropTable(
                name: "Invitations");

            migrationBuilder.DropTable(
                name: "Participants");
        }
    }
}
