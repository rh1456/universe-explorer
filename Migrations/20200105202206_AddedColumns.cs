using Microsoft.EntityFrameworkCore.Migrations;

namespace universeexplorer.Migrations
{
    public partial class AddedColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HouseAffiliation",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "SchoolHouseId",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentsId",
                table: "Students",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolHouseId",
                table: "Students",
                column: "SchoolHouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentsId",
                table: "Students",
                column: "StudentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_SchoolHouses_SchoolHouseId",
                table: "Students",
                column: "SchoolHouseId",
                principalTable: "SchoolHouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Students_StudentsId",
                table: "Students",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_SchoolHouses_SchoolHouseId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Students_StudentsId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_SchoolHouseId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentsId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "SchoolHouseId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentsId",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "HouseAffiliation",
                table: "Students",
                type: "text",
                nullable: true);
        }
    }
}
