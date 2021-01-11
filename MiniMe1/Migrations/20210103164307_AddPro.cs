using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniMe1.Migrations
{
    public partial class AddPro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Colors2",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Colors3",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Colors4",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pictures2",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pictures3",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pictures4",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pictures5",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Size10",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size2",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size3",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size4",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size5",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size6",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size7",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size8",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size9",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Pay",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    CreditNum = table.Column<int>(maxLength: 16, nullable: false),
                    ExpireMonth = table.Column<int>(nullable: false),
                    ExpireYear = table.Column<int>(nullable: false),
                    OwnName = table.Column<string>(maxLength: 30, nullable: false),
                    IdNum = table.Column<string>(maxLength: 15, nullable: false),
                    CW = table.Column<string>(maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pay", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pay");

            migrationBuilder.DropColumn(
                name: "Colors2",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Colors3",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Colors4",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Pictures2",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Pictures3",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Pictures4",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Pictures5",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Size10",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Size2",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Size3",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Size4",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Size5",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Size6",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Size7",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Size8",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Size9",
                table: "Products");
        }
    }
}
