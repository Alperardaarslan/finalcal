using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace finalcal.Migrations
{
    public partial class EmlakDbolustur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblemlaklar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    konum = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    fiyat = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblemlaklar", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblemlaklar");
        }
    }
}
