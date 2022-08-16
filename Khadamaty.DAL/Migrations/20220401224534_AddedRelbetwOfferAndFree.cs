using Microsoft.EntityFrameworkCore.Migrations;

namespace Khadamaty.DAL.Migrations
{
    public partial class AddedRelbetwOfferAndFree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OfferId",
                table: "Freelancec",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Freelancec_OfferId",
                table: "Freelancec",
                column: "OfferId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Freelancec_Offer_OfferId",
                table: "Freelancec",
                column: "OfferId",
                principalTable: "Offer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Freelancec_Offer_OfferId",
                table: "Freelancec");

            migrationBuilder.DropIndex(
                name: "IX_Freelancec_OfferId",
                table: "Freelancec");

            migrationBuilder.DropColumn(
                name: "OfferId",
                table: "Freelancec");
        }
    }
}
