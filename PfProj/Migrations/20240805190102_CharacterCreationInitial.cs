using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PfProj.Migrations
{
    /// <inheritdoc />
    public partial class CharacterCreationInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharacterClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    className = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dex = table.Column<int>(type: "int", nullable: false),
                    str = table.Column<int>(type: "int", nullable: false),
                    wis = table.Column<int>(type: "int", nullable: false),
                    magic = table.Column<int>(type: "int", nullable: false),
                    magicResist = table.Column<int>(type: "int", nullable: false),
                    baseScore = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterClasses", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterClasses");
        }
    }
}
