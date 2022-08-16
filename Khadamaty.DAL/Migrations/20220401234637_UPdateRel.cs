using Microsoft.EntityFrameworkCore.Migrations;

namespace Khadamaty.DAL.Migrations
{
    public partial class UPdateRel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Freelance_FreelanceId",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_FreelanceId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "FreelanceId",
                table: "Client");

            migrationBuilder.CreateTable(
                name: "ClientFreelance",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    FreelanceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientFreelance", x => new { x.ClientID, x.FreelanceID });
                    table.ForeignKey(
                        name: "FK_ClientFreelance_Client_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientFreelance_Freelance_FreelanceID",
                        column: x => x.FreelanceID,
                        principalTable: "Freelance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientFreelance_FreelanceID",
                table: "ClientFreelance",
                column: "FreelanceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientFreelance");

            migrationBuilder.AddColumn<int>(
                name: "FreelanceId",
                table: "Client",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Client_FreelanceId",
                table: "Client",
                column: "FreelanceId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Freelance_FreelanceId",
                table: "Client",
                column: "FreelanceId",
                principalTable: "Freelance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
