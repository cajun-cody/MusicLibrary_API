using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MusicLibraryWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Album", "Artist", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "The Arcade", "Hyper Crush", "Pop Rap", 2008, "Candy Store" },
                    { 2, "The Arcade", "Hyper Crush", "Pop Rap", 2008, "Twisted" },
                    { 3, "The Arcade", "Hyper Crush", "Pop Rap", 2008, "Boom Box" },
                    { 4, "The Arcade", "Hyper Crush", "Pop Rap", 2008, "Disco Tech" },
                    { 5, "Kings of Crunk", "Lil Jon", "Rap", 2002, "Get Low" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
