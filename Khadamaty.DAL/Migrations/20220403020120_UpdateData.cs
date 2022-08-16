using Microsoft.EntityFrameworkCore.Migrations;

namespace Khadamaty.DAL.Migrations
{
    public partial class UpdateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Freelance_FreelancecsId",
                table: "Rating");

            migrationBuilder.RenameColumn(
                name: "FreelancecsId",
                table: "Rating",
                newName: "FreelanceId");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_FreelancecsId",
                table: "Rating",
                newName: "IX_Rating_FreelanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Freelance_FreelanceId",
                table: "Rating",
                column: "FreelanceId",
                principalTable: "Freelance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Freelance_FreelanceId",
                table: "Rating");

            migrationBuilder.RenameColumn(
                name: "FreelanceId",
                table: "Rating",
                newName: "FreelancecsId");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_FreelanceId",
                table: "Rating",
                newName: "IX_Rating_FreelancecsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Freelance_FreelancecsId",
                table: "Rating",
                column: "FreelancecsId",
                principalTable: "Freelance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
