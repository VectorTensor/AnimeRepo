using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeRepo.Migrations
{
    /// <inheritdoc />
    public partial class ManytoMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenreModels_AnimeModels_AnimeModelId",
                table: "GenreModels");

            migrationBuilder.DropIndex(
                name: "IX_GenreModels_AnimeModelId",
                table: "GenreModels");

            migrationBuilder.DropColumn(
                name: "AnimeModelId",
                table: "GenreModels");

            migrationBuilder.AddColumn<string>(
                name: "AnimeName",
                table: "AnimeModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "AnimeModelGenreModel",
                columns: table => new
                {
                    AnimeModelsAnimeModelId = table.Column<int>(type: "int", nullable: false),
                    GenreModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeModelGenreModel", x => new { x.AnimeModelsAnimeModelId, x.GenreModelId });
                    table.ForeignKey(
                        name: "FK_AnimeModelGenreModel_AnimeModels_AnimeModelsAnimeModelId",
                        column: x => x.AnimeModelsAnimeModelId,
                        principalTable: "AnimeModels",
                        principalColumn: "AnimeModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimeModelGenreModel_GenreModels_GenreModelId",
                        column: x => x.GenreModelId,
                        principalTable: "GenreModels",
                        principalColumn: "GenreModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimeModelGenreModel_GenreModelId",
                table: "AnimeModelGenreModel",
                column: "GenreModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimeModelGenreModel");

            migrationBuilder.DropColumn(
                name: "AnimeName",
                table: "AnimeModels");

            migrationBuilder.AddColumn<int>(
                name: "AnimeModelId",
                table: "GenreModels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GenreModels_AnimeModelId",
                table: "GenreModels",
                column: "AnimeModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_GenreModels_AnimeModels_AnimeModelId",
                table: "GenreModels",
                column: "AnimeModelId",
                principalTable: "AnimeModels",
                principalColumn: "AnimeModelId");
        }
    }
}
