using Microsoft.EntityFrameworkCore.Migrations;

namespace HeroData.Migrations
{
    public partial class AddSuperPowerEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "superhero",
                keyColumn: "id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "superhero",
                keyColumn: "id",
                keyValue: -1);

            migrationBuilder.CreateTable(
                name: "SuperPowers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OwnerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperPowers", x => x.id);
                    table.ForeignKey(
                        name: "FK_SuperPowers_superhero_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "superhero",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "superhero",
                columns: new[] { "id", "Alias", "HideOut", "RealName" },
                values: new object[] { 1, "Spiderman", "His study room", "Peter Parker" });

            migrationBuilder.InsertData(
                table: "superhero",
                columns: new[] { "id", "Alias", "HideOut", "RealName" },
                values: new object[] { 2, "Thor", "Asgard", "Thor" });

            migrationBuilder.InsertData(
                table: "SuperPowers",
                columns: new[] { "id", "Description", "Name", "OwnerId" },
                values: new object[] { 1, "Can climb any building and throw web at the enemy", "spider abilities", 1 });

            migrationBuilder.InsertData(
                table: "SuperPowers",
                columns: new[] { "id", "Description", "Name", "OwnerId" },
                values: new object[] { 2, "It can kill any enemy and open Asgard gates", "Magical hammer", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_SuperPowers_OwnerId",
                table: "SuperPowers",
                column: "OwnerId",
                unique: true,
                filter: "[OwnerId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuperPowers");

            migrationBuilder.DeleteData(
                table: "superhero",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "superhero",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "superhero",
                columns: new[] { "id", "Alias", "HideOut", "RealName" },
                values: new object[] { -1, "Spiderman", "His study room", "Peter Parker" });

            migrationBuilder.InsertData(
                table: "superhero",
                columns: new[] { "id", "Alias", "HideOut", "RealName" },
                values: new object[] { -2, "Thor", "Asgard", "Thor" });
        }
    }
}
