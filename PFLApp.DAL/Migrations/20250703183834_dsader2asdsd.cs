using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PFLApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class dsader2asdsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Teams_StadionId",
                table: "Teams");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_StadionId",
                table: "Teams",
                column: "StadionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Teams_StadionId",
                table: "Teams");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_StadionId",
                table: "Teams",
                column: "StadionId",
                unique: true);
        }
    }
}
