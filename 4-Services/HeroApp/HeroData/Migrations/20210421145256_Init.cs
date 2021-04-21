using Microsoft.EntityFrameworkCore.Migrations;

namespace HeroData.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "superhero",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RealName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HideOut = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_superhero", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "superhero",
                columns: new[] { "id", "Alias", "HideOut", "RealName" },
                values: new object[] { -1, "Spiderman", "His study room", "Peter Parker" });

            migrationBuilder.InsertData(
                table: "superhero",
                columns: new[] { "id", "Alias", "HideOut", "RealName" },
                values: new object[] { -2, "Thor", "Asgard", "Thor" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "superhero");
        }
    }
}
