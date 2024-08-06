using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PfProj.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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

            migrationBuilder.CreateTable(
                name: "CharacterClassItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    className = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    itemID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterClassItems", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    weight = table.Column<double>(type: "float", nullable: false),
                    value = table.Column<int>(type: "int", nullable: false),
                    typeOfItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    slotType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isEquipped = table.Column<bool>(type: "bit", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maxHitPointBonus = table.Column<int>(type: "int", nullable: true),
                    currentHitPointBonus = table.Column<int>(type: "int", nullable: true),
                    meleeDamageBonus = table.Column<int>(type: "int", nullable: true),
                    rangedDamageBonus = table.Column<int>(type: "int", nullable: true),
                    magicDamageBonus = table.Column<int>(type: "int", nullable: true),
                    meleeAttackBonus = table.Column<int>(type: "int", nullable: true),
                    rangedAttackBonus = table.Column<int>(type: "int", nullable: true),
                    magicAttackBonus = table.Column<int>(type: "int", nullable: true),
                    armorClassBonus = table.Column<int>(type: "int", nullable: true),
                    attackType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    typeOfDamage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strRequirement = table.Column<int>(type: "int", nullable: true),
                    dexRequirement = table.Column<int>(type: "int", nullable: true),
                    wisRequirement = table.Column<int>(type: "int", nullable: true),
                    magicRequirement = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterClasses");

            migrationBuilder.DropTable(
                name: "CharacterClassItems");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
