using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySecondProject.Migrations
{
    /// <inheritdoc />
    public partial class AddedSedingDataaDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2025, 7, 21, 12, 20, 5, 584, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2025, 7, 21, 12, 20, 5, 587, DateTimeKind.Local).AddTicks(1814));
        }
    }
}
