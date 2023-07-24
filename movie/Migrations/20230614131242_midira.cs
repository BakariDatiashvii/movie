using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace movie.Migrations
{
    /// <inheritdoc />
    public partial class midira : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "film",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    janri = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_film", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "msaxiobi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gvari = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    asaki = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_msaxiobi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "filmpiradis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rejisori = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shemosavali = table.Column<int>(type: "int", nullable: false),
                    filmebisid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filmpiradis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_filmpiradis_film_filmebisid",
                        column: x => x.filmebisid,
                        principalTable: "film",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "filmmsaxiobi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    filmID = table.Column<int>(type: "int", nullable: false),
                    msaxiobiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filmmsaxiobi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_filmmsaxiobi_film_filmID",
                        column: x => x.filmID,
                        principalTable: "film",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_filmmsaxiobi_msaxiobi_msaxiobiID",
                        column: x => x.msaxiobiID,
                        principalTable: "msaxiobi",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "msaxiobispiradis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    piradinomeri = table.Column<int>(type: "int", nullable: false),
                    kanisferi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shemosavali = table.Column<int>(type: "int", nullable: false),
                    msaxiobiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_msaxiobispiradis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_msaxiobispiradis_msaxiobi_msaxiobiId",
                        column: x => x.msaxiobiId,
                        principalTable: "msaxiobi",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_filmmsaxiobi_filmID",
                table: "filmmsaxiobi",
                column: "filmID");

            migrationBuilder.CreateIndex(
                name: "IX_filmmsaxiobi_msaxiobiID",
                table: "filmmsaxiobi",
                column: "msaxiobiID");

            migrationBuilder.CreateIndex(
                name: "IX_filmpiradis_filmebisid",
                table: "filmpiradis",
                column: "filmebisid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_msaxiobispiradis_msaxiobiId",
                table: "msaxiobispiradis",
                column: "msaxiobiId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "filmmsaxiobi");

            migrationBuilder.DropTable(
                name: "filmpiradis");

            migrationBuilder.DropTable(
                name: "msaxiobispiradis");

            migrationBuilder.DropTable(
                name: "film");

            migrationBuilder.DropTable(
                name: "msaxiobi");
        }
    }
}
