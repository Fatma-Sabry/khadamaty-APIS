using Microsoft.EntityFrameworkCore.Migrations;

namespace Khadamaty.DAL.Migrations
{
    public partial class AddedRelbtweenProAndFree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Freelance",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Freelance_ProjectId",
                table: "Freelance",
                column: "ProjectId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Freelance_Project_ProjectId",
                table: "Freelance",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Freelance_Project_ProjectId",
                table: "Freelance");

            migrationBuilder.DropIndex(
                name: "IX_Freelance_ProjectId",
                table: "Freelance");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Freelance");
        }
    }
}
