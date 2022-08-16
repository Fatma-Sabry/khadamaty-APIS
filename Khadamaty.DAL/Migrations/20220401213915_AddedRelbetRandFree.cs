using Microsoft.EntityFrameworkCore.Migrations;

namespace Khadamaty.DAL.Migrations
{
    public partial class AddedRelbetRandFree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FreelancecsId",
                table: "Rating",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rating_FreelancecsId",
                table: "Rating",
                column: "FreelancecsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Freelancec_FreelancecsId",
                table: "Rating",
                column: "FreelancecsId",
                principalTable: "Freelancec",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Freelancec_FreelancecsId",
                table: "Rating");

            migrationBuilder.DropIndex(
                name: "IX_Rating_FreelancecsId",
                table: "Rating");

            migrationBuilder.DropColumn(
                name: "FreelancecsId",
                table: "Rating");
        }
    }
}
