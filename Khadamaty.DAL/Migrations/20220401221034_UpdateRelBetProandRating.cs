using Microsoft.EntityFrameworkCore.Migrations;

namespace Khadamaty.DAL.Migrations
{
    public partial class UpdateRelBetProandRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Rating_ProjectId",
                table: "Rating");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_ProjectId",
                table: "Rating",
                column: "ProjectId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Rating_ProjectId",
                table: "Rating");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_ProjectId",
                table: "Rating",
                column: "ProjectId");
        }
    }
}
