using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "EntryId", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Went running in the morning. I did 10km in an hour.", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Went running" },
                    { 2, "I did workouts in the morning, for about 40 minutes.", new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morning workout" },
                    { 3, "Went to the supermarket and bought vegetables and fruits for the week.", new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grocery Shopping" },
                    { 4, "Watched an inspiring documentary about space exploration.", new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watched a Movie" },
                    { 5, "Cooked homemade pasta with a delicious creamy sauce.", new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tried a New Recipe" },
                    { 6, "Had a relaxing yoga session in the evening.", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yoga Session" },
                    { 7, "Finished reading 'The Alchemist' by Paulo Coelho.", new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Read a Book" },
                    { 8, "Did a thorough cleaning of the entire house.", new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cleaned the House" },
                    { 9, "Had a lovely lunch with friends at a nearby cafe.", new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Met Friends" },
                    { 10, "Planted a small sapling in the garden.", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Planted a Tree" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "EntryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "EntryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "EntryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "EntryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "EntryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "EntryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "EntryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "EntryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "EntryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "EntryId",
                keyValue: 10);
        }
    }
}
