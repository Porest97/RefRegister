using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RefRegister.Migrations
{
    public partial class Domarlista : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Domarlista",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    RefNumber = table.Column<string>(nullable: true),
                    BirthDate = table.Column<string>(nullable: true),
                    RefType = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    CategoryType = table.Column<string>(nullable: true),
                    Distrikt = table.Column<string>(nullable: true),
                    Club = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    Zipcode = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Phone1 = table.Column<string>(nullable: true),
                    Phone2 = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Registred = table.Column<string>(nullable: true),
                    Created = table.Column<string>(nullable: true),
                    Payed = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domarlista", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Domarlista");
        }
    }
}
