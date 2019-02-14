using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RefRegister.Migrations
{
    public partial class Games : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Match");

            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MatchNumber = table.Column<string>(nullable: true),
                    GameDate = table.Column<string>(nullable: true),
                    Arena = table.Column<string>(nullable: true),
                    Team1 = table.Column<string>(nullable: true),
                    Team2 = table.Column<string>(nullable: true),
                    Score1 = table.Column<string>(nullable: true),
                    Score2 = table.Column<string>(nullable: true),
                    Ref1 = table.Column<string>(nullable: true),
                    Ref2 = table.Column<string>(nullable: true),
                    Ref3 = table.Column<string>(nullable: true),
                    Ref4 = table.Column<string>(nullable: true),
                    Fee1 = table.Column<string>(nullable: true),
                    Fee2 = table.Column<string>(nullable: true),
                    Fee3 = table.Column<string>(nullable: true),
                    Fee4 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.CreateTable(
                name: "Match",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Arena = table.Column<string>(nullable: true),
                    DateTime = table.Column<string>(nullable: true),
                    Fee1 = table.Column<string>(nullable: true),
                    Fee2 = table.Column<string>(nullable: true),
                    Fee3 = table.Column<string>(nullable: true),
                    Fee4 = table.Column<string>(nullable: true),
                    MatchNumber = table.Column<string>(nullable: true),
                    MatchStatus = table.Column<string>(nullable: true),
                    Ref1 = table.Column<string>(nullable: true),
                    Ref2 = table.Column<string>(nullable: true),
                    Ref3 = table.Column<string>(nullable: true),
                    Ref4 = table.Column<string>(nullable: true),
                    Score1 = table.Column<string>(nullable: true),
                    Score2 = table.Column<string>(nullable: true),
                    Team1 = table.Column<string>(nullable: true),
                    Team2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match", x => x.Id);
                });
        }
    }
}
