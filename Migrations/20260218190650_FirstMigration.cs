using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TikTokTools.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationConfig",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TempFolderPath = table.Column<string>(type: "TEXT", nullable: false),
                    OutputFolderPath = table.Column<string>(type: "TEXT", nullable: false),
                    TikTokApiKey = table.Column<string>(type: "TEXT", nullable: false),
                    ElevenLabsApiKey = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationConfig", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationConfig");
        }
    }
}
