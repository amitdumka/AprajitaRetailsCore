using Microsoft.EntityFrameworkCore.Migrations;

namespace AprajitaRetails.DL.Migrations
{
    public partial class NextStage2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StaffName",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "StaffName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
