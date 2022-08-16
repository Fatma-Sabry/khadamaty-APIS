using Microsoft.EntityFrameworkCore.Migrations;

namespace Khadamaty.DAL.Migrations
{
    public partial class UpdateOnrelbtweclientAndFree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Freelancec_FreelancecsId",
                table: "Rating");

            migrationBuilder.DropTable(
                name: "ClientFreelance");

            migrationBuilder.DropTable(
                name: "Freelancec");

            migrationBuilder.AddColumn<int>(
                name: "FreelanceId",
                table: "Client",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Freelance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfferId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Freelance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Freelance_Offer_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_FreelanceId",
                table: "Client",
                column: "FreelanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Freelance_OfferId",
                table: "Freelance",
                column: "OfferId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Freelance_FreelanceId",
                table: "Client",
                column: "FreelanceId",
                principalTable: "Freelance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Freelance_FreelancecsId",
                table: "Rating",
                column: "FreelancecsId",
                principalTable: "Freelance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Freelance_FreelanceId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Freelance_FreelancecsId",
                table: "Rating");

            migrationBuilder.DropTable(
                name: "Freelance");

            migrationBuilder.DropIndex(
                name: "IX_Client_FreelanceId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "FreelanceId",
                table: "Client");

            migrationBuilder.CreateTable(
                name: "Freelancec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfferId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Freelancec", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Freelancec_Offer_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientFreelance",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    FreelanceID = table.Column<int>(type: "int", nullable: false),
                    FreelancecsId = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_ClientFreelance_Freelancec_FreelancecsId",
                        column: x => x.FreelancecsId,
                        principalTable: "Freelancec",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientFreelance_FreelancecsId",
                table: "ClientFreelance",
                column: "FreelancecsId");

            migrationBuilder.CreateIndex(
                name: "IX_Freelancec_OfferId",
                table: "Freelancec",
                column: "OfferId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Freelancec_FreelancecsId",
                table: "Rating",
                column: "FreelancecsId",
                principalTable: "Freelancec",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
