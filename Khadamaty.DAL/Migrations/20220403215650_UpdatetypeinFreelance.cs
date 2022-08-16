using Microsoft.EntityFrameworkCore.Migrations;

namespace Khadamaty.DAL.Migrations
{
    public partial class UpdatetypeinFreelance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Freelance_Offer_OfferId",
                table: "Freelance");

            migrationBuilder.DropForeignKey(
                name: "FK_Freelance_Project_ProjectId",
                table: "Freelance");

            migrationBuilder.DropIndex(
                name: "IX_Freelance_OfferId",
                table: "Freelance");

            migrationBuilder.DropIndex(
                name: "IX_Freelance_ProjectId",
                table: "Freelance");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Freelance",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OfferId",
                table: "Freelance",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Freelance_OfferId",
                table: "Freelance",
                column: "OfferId",
                unique: true,
                filter: "[OfferId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Freelance_ProjectId",
                table: "Freelance",
                column: "ProjectId",
                unique: true,
                filter: "[ProjectId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Freelance_Offer_OfferId",
                table: "Freelance",
                column: "OfferId",
                principalTable: "Offer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Freelance_Offer_OfferId",
                table: "Freelance");

            migrationBuilder.DropForeignKey(
                name: "FK_Freelance_Project_ProjectId",
                table: "Freelance");

            migrationBuilder.DropIndex(
                name: "IX_Freelance_OfferId",
                table: "Freelance");

            migrationBuilder.DropIndex(
                name: "IX_Freelance_ProjectId",
                table: "Freelance");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Freelance",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OfferId",
                table: "Freelance",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Freelance_OfferId",
                table: "Freelance",
                column: "OfferId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Freelance_ProjectId",
                table: "Freelance",
                column: "ProjectId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Freelance_Offer_OfferId",
                table: "Freelance",
                column: "OfferId",
                principalTable: "Offer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Freelance_Project_ProjectId",
                table: "Freelance",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
