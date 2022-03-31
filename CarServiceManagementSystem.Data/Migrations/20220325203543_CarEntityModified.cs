using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarServiceManagementSystem.Data.Migrations
{
    public partial class CarEntityModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarWarehouses_WarehouseId",
                table: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "WarehouseId",
                table: "Cars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarWarehouses_WarehouseId",
                table: "Cars",
                column: "WarehouseId",
                principalTable: "CarWarehouses",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarWarehouses_WarehouseId",
                table: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "WarehouseId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarWarehouses_WarehouseId",
                table: "Cars",
                column: "WarehouseId",
                principalTable: "CarWarehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
