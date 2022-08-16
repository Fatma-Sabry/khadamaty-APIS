using Microsoft.EntityFrameworkCore.Migrations;

namespace Khadamaty.DAL.Migrations
{
    public partial class updataRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Client_ClienttId",
                table: "Rating");

            migrationBuilder.DropIndex(
                name: "IX_Rating_ClienttId",
                table: "Rating");

            migrationBuilder.DropColumn(
                name: "ClienttId",
                table: "Rating");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_ClientId",
                table: "Rating",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Client_ClientId",
                table: "Rating",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Client_ClientId",
                table: "Rating");

            migrationBuilder.DropIndex(
                name: "IX_Rating_ClientId",
                table: "Rating");

            migrationBuilder.AddColumn<int>(
                name: "ClienttId",
                table: "Rating",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rating_ClienttId",
                table: "Rating",
                column: "ClienttId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Client_ClienttId",
                table: "Rating",
                column: "ClienttId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
