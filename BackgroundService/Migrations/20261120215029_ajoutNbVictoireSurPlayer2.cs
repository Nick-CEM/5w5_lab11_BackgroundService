using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackgroundService.Migrations
{
    /// <inheritdoc />
    public partial class ajoutNbVictoireSurPlayer2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NbVictoire",
                table: "Player",
                newName: "NbWins");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NbWins",
                table: "Player",
                newName: "NbVictoire");
        }
    }
}
