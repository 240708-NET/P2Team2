using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PfProj.Migrations
{
    /// <inheritdoc />
    public partial class CharacterCreationPlusClassInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    characterClassName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    level = table.Column<int>(type: "int", nullable: true),
                    experience = table.Column<int>(type: "int", nullable: true),
                    currentHitPoints = table.Column<int>(type: "int", nullable: true),
                    gold = table.Column<int>(type: "int", nullable: true),
                    str = table.Column<int>(type: "int", nullable: true),
                    dex = table.Column<int>(type: "int", nullable: true),
                    wis = table.Column<int>(type: "int", nullable: true),
                    magic = table.Column<int>(type: "int", nullable: true),
                    magicResist = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
