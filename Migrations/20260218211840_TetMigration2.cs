using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TikTokTools.Migrations
{
    /// <inheritdoc />
    public partial class TetMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationConfig",
                table: "ApplicationConfig");

            migrationBuilder.RenameTable(
                name: "ApplicationConfig",
                newName: "AppConfig");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppConfig",
                table: "AppConfig",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppConfig",
                table: "AppConfig");

            migrationBuilder.RenameTable(
                name: "AppConfig",
                newName: "ApplicationConfig");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationConfig",
                table: "ApplicationConfig",
                column: "Id");
        }
    }
}
