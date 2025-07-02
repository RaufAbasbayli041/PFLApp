using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PFLApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _3cu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Week",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Week",
                table: "Matches");
        }
    }
}
