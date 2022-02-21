using Microsoft.EntityFrameworkCore.Migrations;

namespace WinForms_Films.Migrations
{
    public partial class create_Pivot_FilmGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FilmGenre_Films_FilmsId",
                table: "FilmGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_FilmGenre_Genres_GenresId",
                table: "FilmGenre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilmGenre",
                table: "FilmGenre");

            migrationBuilder.RenameTable(
                name: "FilmGenre",
                newName: "Pivot_FilmGenre");

            migrationBuilder.RenameIndex(
                name: "IX_FilmGenre_GenresId",
                table: "Pivot_FilmGenre",
                newName: "IX_Pivot_FilmGenre_GenresId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pivot_FilmGenre",
                table: "Pivot_FilmGenre",
                columns: new[] { "FilmsId", "GenresId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Pivot_FilmGenre_Films_FilmsId",
                table: "Pivot_FilmGenre",
                column: "FilmsId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pivot_FilmGenre_Genres_GenresId",
                table: "Pivot_FilmGenre",
                column: "GenresId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pivot_FilmGenre_Films_FilmsId",
                table: "Pivot_FilmGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_Pivot_FilmGenre_Genres_GenresId",
                table: "Pivot_FilmGenre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pivot_FilmGenre",
                table: "Pivot_FilmGenre");

            migrationBuilder.RenameTable(
                name: "Pivot_FilmGenre",
                newName: "FilmGenre");

            migrationBuilder.RenameIndex(
                name: "IX_Pivot_FilmGenre_GenresId",
                table: "FilmGenre",
                newName: "IX_FilmGenre_GenresId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilmGenre",
                table: "FilmGenre",
                columns: new[] { "FilmsId", "GenresId" });

            migrationBuilder.AddForeignKey(
                name: "FK_FilmGenre_Films_FilmsId",
                table: "FilmGenre",
                column: "FilmsId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FilmGenre_Genres_GenresId",
                table: "FilmGenre",
                column: "GenresId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
