using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Naruto.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jutsus",
                columns: table => new
                {
                    JutsuId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TechniqueName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jutsus", x => x.JutsuId);
                });

            migrationBuilder.CreateTable(
                name: "Ninjas",
                columns: table => new
                {
                    NinjaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Chakra = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ninjas", x => x.NinjaId);
                });

            migrationBuilder.CreateTable(
                name: "Ninjitsus",
                columns: table => new
                {
                    NinjutsuId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NinjaId = table.Column<int>(nullable: false),
                    JutsuId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ninjitsus", x => x.NinjutsuId);
                    table.ForeignKey(
                        name: "FK_Ninjitsus_Jutsus_JutsuId",
                        column: x => x.JutsuId,
                        principalTable: "Jutsus",
                        principalColumn: "JutsuId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ninjitsus_Ninjas_NinjaId",
                        column: x => x.NinjaId,
                        principalTable: "Ninjas",
                        principalColumn: "NinjaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ninjitsus_JutsuId",
                table: "Ninjitsus",
                column: "JutsuId");

            migrationBuilder.CreateIndex(
                name: "IX_Ninjitsus_NinjaId",
                table: "Ninjitsus",
                column: "NinjaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ninjitsus");

            migrationBuilder.DropTable(
                name: "Jutsus");

            migrationBuilder.DropTable(
                name: "Ninjas");
        }
    }
}
