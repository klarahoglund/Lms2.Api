using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lms2.Data.Migrations
{
    public partial class new2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Module_Course_CourseId1",
                table: "Module");

            migrationBuilder.DropIndex(
                name: "IX_Module_CourseId1",
                table: "Module");

            migrationBuilder.DropColumn(
                name: "CourseId1",
                table: "Module");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Module",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Module_CourseId",
                table: "Module",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Module_Course_CourseId",
                table: "Module",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Module_Course_CourseId",
                table: "Module");

            migrationBuilder.DropIndex(
                name: "IX_Module_CourseId",
                table: "Module");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Module");

            migrationBuilder.AddColumn<int>(
                name: "CourseId1",
                table: "Module",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Module_CourseId1",
                table: "Module",
                column: "CourseId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Module_Course_CourseId1",
                table: "Module",
                column: "CourseId1",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
