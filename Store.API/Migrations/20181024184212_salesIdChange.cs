using Microsoft.EntityFrameworkCore.Migrations;

namespace Store.API.Migrations
{
    public partial class salesIdChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "SalesExecutiveId",
                table: "Employees",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employees",
                newName: "SalesExecutiveId");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Employees",
                nullable: true);
        }
    }
}
