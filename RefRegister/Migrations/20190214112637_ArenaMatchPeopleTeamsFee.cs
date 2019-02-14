using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RefRegister.Migrations
{
    public partial class ArenaMatchPeopleTeamsFee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "Referee",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MatchId1",
                table: "Referee",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MatchId2",
                table: "Referee",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MatchId3",
                table: "Referee",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Match",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MatchNumber = table.Column<int>(nullable: false),
                    GameDate = table.Column<DateTime>(nullable: false),
                    Score1 = table.Column<int>(nullable: false),
                    Score2 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Arena",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    Phonenumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MatchId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arena", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arena_Match_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Match",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    MatchId = table.Column<int>(nullable: true),
                    MatchId1 = table.Column<int>(nullable: true),
                    MatchId2 = table.Column<int>(nullable: true),
                    MatchId3 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fee_Match_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Match",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fee_Match_MatchId1",
                        column: x => x.MatchId1,
                        principalTable: "Match",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fee_Match_MatchId2",
                        column: x => x.MatchId2,
                        principalTable: "Match",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fee_Match_MatchId3",
                        column: x => x.MatchId3,
                        principalTable: "Match",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    Phonenumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MatchId = table.Column<int>(nullable: true),
                    MatchId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Team_Match_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Match",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Team_Match_MatchId1",
                        column: x => x.MatchId1,
                        principalTable: "Match",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    RefNumber = table.Column<string>(nullable: true),
                    BirthDate = table.Column<string>(nullable: true),
                    StaffType = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    Zipcode = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Phone1 = table.Column<string>(nullable: true),
                    Phone2 = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    TeamId = table.Column<int>(nullable: true),
                    TeamId1 = table.Column<int>(nullable: true),
                    TeamId2 = table.Column<int>(nullable: true),
                    TeamId3 = table.Column<int>(nullable: true),
                    TeamId4 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Team_TeamId1",
                        column: x => x.TeamId1,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Team_TeamId2",
                        column: x => x.TeamId2,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Team_TeamId3",
                        column: x => x.TeamId3,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Team_TeamId4",
                        column: x => x.TeamId4,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Referee_MatchId",
                table: "Referee",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Referee_MatchId1",
                table: "Referee",
                column: "MatchId1");

            migrationBuilder.CreateIndex(
                name: "IX_Referee_MatchId2",
                table: "Referee",
                column: "MatchId2");

            migrationBuilder.CreateIndex(
                name: "IX_Referee_MatchId3",
                table: "Referee",
                column: "MatchId3");

            migrationBuilder.CreateIndex(
                name: "IX_Arena_MatchId",
                table: "Arena",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Fee_MatchId",
                table: "Fee",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Fee_MatchId1",
                table: "Fee",
                column: "MatchId1");

            migrationBuilder.CreateIndex(
                name: "IX_Fee_MatchId2",
                table: "Fee",
                column: "MatchId2");

            migrationBuilder.CreateIndex(
                name: "IX_Fee_MatchId3",
                table: "Fee",
                column: "MatchId3");

            migrationBuilder.CreateIndex(
                name: "IX_Person_TeamId",
                table: "Person",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_TeamId1",
                table: "Person",
                column: "TeamId1");

            migrationBuilder.CreateIndex(
                name: "IX_Person_TeamId2",
                table: "Person",
                column: "TeamId2");

            migrationBuilder.CreateIndex(
                name: "IX_Person_TeamId3",
                table: "Person",
                column: "TeamId3");

            migrationBuilder.CreateIndex(
                name: "IX_Person_TeamId4",
                table: "Person",
                column: "TeamId4");

            migrationBuilder.CreateIndex(
                name: "IX_Team_MatchId",
                table: "Team",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_MatchId1",
                table: "Team",
                column: "MatchId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Referee_Match_MatchId",
                table: "Referee",
                column: "MatchId",
                principalTable: "Match",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Referee_Match_MatchId1",
                table: "Referee",
                column: "MatchId1",
                principalTable: "Match",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Referee_Match_MatchId2",
                table: "Referee",
                column: "MatchId2",
                principalTable: "Match",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Referee_Match_MatchId3",
                table: "Referee",
                column: "MatchId3",
                principalTable: "Match",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Referee_Match_MatchId",
                table: "Referee");

            migrationBuilder.DropForeignKey(
                name: "FK_Referee_Match_MatchId1",
                table: "Referee");

            migrationBuilder.DropForeignKey(
                name: "FK_Referee_Match_MatchId2",
                table: "Referee");

            migrationBuilder.DropForeignKey(
                name: "FK_Referee_Match_MatchId3",
                table: "Referee");

            migrationBuilder.DropTable(
                name: "Arena");

            migrationBuilder.DropTable(
                name: "Fee");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Match");

            migrationBuilder.DropIndex(
                name: "IX_Referee_MatchId",
                table: "Referee");

            migrationBuilder.DropIndex(
                name: "IX_Referee_MatchId1",
                table: "Referee");

            migrationBuilder.DropIndex(
                name: "IX_Referee_MatchId2",
                table: "Referee");

            migrationBuilder.DropIndex(
                name: "IX_Referee_MatchId3",
                table: "Referee");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "Referee");

            migrationBuilder.DropColumn(
                name: "MatchId1",
                table: "Referee");

            migrationBuilder.DropColumn(
                name: "MatchId2",
                table: "Referee");

            migrationBuilder.DropColumn(
                name: "MatchId3",
                table: "Referee");
        }
    }
}
