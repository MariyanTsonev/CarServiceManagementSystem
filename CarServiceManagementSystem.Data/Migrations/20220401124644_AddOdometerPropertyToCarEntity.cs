using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarServiceManagementSystem.Data.Migrations
{
    public partial class AddOdometerPropertyToCarEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Odometer",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Odometer",
                table: "Cars");
        }
    }
}
