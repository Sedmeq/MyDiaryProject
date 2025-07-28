using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySecondProject.Migrations
{
    /// <inheritdoc />
    public partial class AddedSedingDataaDiaryEntry2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2025, 7, 21, 12, 27, 45, 541, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2025, 7, 21, 12, 27, 45, 541, DateTimeKind.Local).AddTicks(7470));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
