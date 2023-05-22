using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataForDifficultiesandRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("062ba027-d986-45c9-b530-d8cf3ef9e3bb"), "Easy" },
                    { new Guid("40c3e47a-62b9-4dac-bc9e-1280c3a1c705"), "Hard" },
                    { new Guid("4bf45d76-7d26-4561-ac69-126a8b0db4ed"), "Medium" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("4d590d3c-1a2c-404d-81d4-ddd965600ad5"), "NTL", "North Land", "https://i.imgur.com/BweUjJK.jpeg" },
                    { new Guid("a113c477-3389-4500-9176-bc4b8de0a6fa"), "NSN", "Nelson", "https://i.imgur.com/uNZ2GwE.jpeg" },
                    { new Guid("be195175-e8ca-4da7-95b9-89377a378715"), "BOP", "Blay of Plenty", null },
                    { new Guid("f72fd8d6-7bbf-4912-a331-3db5406ed056"), "WGN", "Wellington", null },
                    { new Guid("f72fd8d6-7bbf-4912-a331-3db5406ed059"), "AKL", "Auckland", null },
                    { new Guid("fca2fe0f-0967-4e7f-b379-a16871b887ca"), "STL", "Southland", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("062ba027-d986-45c9-b530-d8cf3ef9e3bb"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("40c3e47a-62b9-4dac-bc9e-1280c3a1c705"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("4bf45d76-7d26-4561-ac69-126a8b0db4ed"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("4d590d3c-1a2c-404d-81d4-ddd965600ad5"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a113c477-3389-4500-9176-bc4b8de0a6fa"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("be195175-e8ca-4da7-95b9-89377a378715"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f72fd8d6-7bbf-4912-a331-3db5406ed056"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f72fd8d6-7bbf-4912-a331-3db5406ed059"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("fca2fe0f-0967-4e7f-b379-a16871b887ca"));
        }
    }
}
