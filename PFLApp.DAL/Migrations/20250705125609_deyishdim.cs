using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PFLApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class deyishdim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AwayTeamId",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwayTeamId",
                table: "Teams");
        }
    }
}
