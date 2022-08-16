using Microsoft.EntityFrameworkCore.Migrations;

namespace Khadamaty.DAL.Migrations
{
    public partial class SuredOldData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offer_Project_ProjectID",
                table: "Offer");

            migrationBuilder.RenameColumn(
                name: "ProjectID",
                table: "Offer",
                newName: "ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Offer_ProjectID",
                table: "Offer",
                newName: "IX_Offer_ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offer_Project_ProjectId",
                table: "Offer",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offer_Project_ProjectId",
                table: "Offer");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "Offer",
                newName: "ProjectID");

            migrationBuilder.RenameIndex(
                name: "IX_Offer_ProjectId",
                table: "Offer",
                newName: "IX_Offer_ProjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_Offer_Project_ProjectID",
                table: "Offer",
                column: "ProjectID",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
