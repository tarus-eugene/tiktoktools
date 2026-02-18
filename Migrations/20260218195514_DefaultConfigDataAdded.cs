using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TikTokTools.Migrations
{
    /// <inheritdoc />
    public partial class DefaultConfigDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApplicationConfig",
                columns: new[] { "Id", "ElevenLabsApiKey", "OutputFolderPath", "TempFolderPath", "TikTokApiKey" },
                values: new object[] { 1, "", "C:\\TikTokTools\\Output", "C:\\TikTokTools\\Temp", "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationConfig",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
