using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PFLApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Salammmm1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchScorers_Players_PlayerId",
                table: "MatchScorers");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchScorers_Players_PlayerId",
                table: "MatchScorers",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchScorers_Players_PlayerId",
                table: "MatchScorers");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchScorers_Players_PlayerId",
                table: "MatchScorers",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
