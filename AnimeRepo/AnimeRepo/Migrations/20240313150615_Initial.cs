using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeRepo.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnimeModels",
                columns: table => new
                {
                    AnimeModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeModels", x => x.AnimeModelId);
                });

            migrationBuilder.CreateTable(
                name: "GenreModels",
                columns: table => new
                {
                    GenreModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimeModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreModels", x => x.GenreModelId);
                    table.ForeignKey(
                        name: "FK_GenreModels_AnimeModels_AnimeModelId",
                        column: x => x.AnimeModelId,
                        principalTable: "AnimeModels",
                        principalColumn: "AnimeModelId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_GenreModels_AnimeModelId",
                table: "GenreModels",
                column: "AnimeModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GenreModels");

            migrationBuilder.DropTable(
                name: "AnimeModels");
        }
    }
}
