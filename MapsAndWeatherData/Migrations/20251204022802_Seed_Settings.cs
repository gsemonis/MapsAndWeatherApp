using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MapsAndWeatherData.Migrations
{
    /// <inheritdoc />
    public partial class Seed_Settings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Settings_Name",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Settings");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Settings",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Settings",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Settings_Key",
                table: "Settings",
                column: "Key",
                unique: true)
                .Annotation("SqlServer:Include", new[] { "Value" });

            migrationBuilder.Sql(@"INSERT INTO [Settings] ([Key], [Value]) VALUES (N'GoogleAPIKey', N'AIzaSyDBFg7HAnVAl78i0m7auBzrQVleaSD_DRo')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Settings_Key",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "Settings");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Settings",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Settings",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Settings_Name",
                table: "Settings",
                column: "Name",
                unique: true)
                .Annotation("SqlServer:Include", new[] { "Value" });

            migrationBuilder.Sql(@"DELETE FROM [Settings] WHERE [KEY] = N'GoogleAPIKey'");
        }
    }
}
