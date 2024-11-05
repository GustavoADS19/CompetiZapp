using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompetiZapp.Migrations
{
    /// <inheritdoc />
    public partial class AddUseDarkModeFromApplicationUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "UseDarkMode",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UseDarkMode",
                table: "AspNetUsers");
        }
    }
}
