using Microsoft.EntityFrameworkCore.Migrations;

namespace Khadamaty.DAL.Migrations
{
    public partial class UpdatetypeinClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Offer_OfferId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_Project_ProjectId",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_OfferId",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_ProjectId",
                table: "Client");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Client",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OfferId",
                table: "Client",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Client_OfferId",
                table: "Client",
                column: "OfferId",
                unique: true,
                filter: "[OfferId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Client_ProjectId",
                table: "Client",
                column: "ProjectId",
                unique: true,
                filter: "[ProjectId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Offer_OfferId",
                table: "Client",
                column: "OfferId",
                principalTable: "Offer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Project_ProjectId",
                table: "Client",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Offer_OfferId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_Project_ProjectId",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_OfferId",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_ProjectId",
                table: "Client");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Client",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OfferId",
                table: "Client",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Client_OfferId",
                table: "Client",
                column: "OfferId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Client_ProjectId",
                table: "Client",
                column: "ProjectId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Offer_OfferId",
                table: "Client",
                column: "OfferId",
                principalTable: "Offer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Project_ProjectId",
                table: "Client",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
