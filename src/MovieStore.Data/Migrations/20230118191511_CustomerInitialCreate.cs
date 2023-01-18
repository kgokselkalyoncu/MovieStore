using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class CustomerInitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 1, 18, 22, 15, 11, 0, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 1, 18, 22, 15, 11, 0, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 1, 18, 22, 15, 11, 0, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 1, 18, 22, 15, 11, 0, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 1, 18, 22, 15, 11, 0, DateTimeKind.Local).AddTicks(9253));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 1, 17, 0, 9, 34, 637, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 1, 17, 0, 9, 34, 637, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 1, 17, 0, 9, 34, 637, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 1, 17, 0, 9, 34, 637, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 1, 17, 0, 9, 34, 637, DateTimeKind.Local).AddTicks(1229));
        }
    }
}
