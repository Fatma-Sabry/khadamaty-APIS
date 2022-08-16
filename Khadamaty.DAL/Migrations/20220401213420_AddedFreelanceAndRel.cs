using Microsoft.EntityFrameworkCore.Migrations;

namespace Khadamaty.DAL.Migrations
{
    public partial class AddedFreelanceAndRel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Freelancec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Freelancec", x => x.Id);
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientFreelance");

            migrationBuilder.DropTable(
                name: "Freelancec");
        }
    }
}
