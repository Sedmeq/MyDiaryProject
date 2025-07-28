using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySecondProject.Migrations
{
    /// <inheritdoc />
    public partial class AddedSedingdataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2025, 7, 21, 12, 16, 15, 593, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2025, 7, 21, 12, 16, 15, 593, DateTimeKind.Local).AddTicks(5115));
        }
    }
}
