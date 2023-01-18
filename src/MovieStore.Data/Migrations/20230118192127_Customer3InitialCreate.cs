using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class Customer3InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerFavoriteMovieGenre_MovieTypes_MovieGenreId",
                table: "CustomerFavoriteMovieGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_MovieTypes_MovieTypeId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieTypes",
                table: "MovieTypes");

            migrationBuilder.RenameTable(
                name: "MovieTypes",
                newName: "MovieGenre");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieGenre",
                table: "MovieGenre",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "MovieGenre",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 1, 18, 22, 21, 27, 803, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "MovieGenre",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 1, 18, 22, 21, 27, 803, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "MovieGenre",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 1, 18, 22, 21, 27, 803, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "MovieGenre",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 1, 18, 22, 21, 27, 803, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "MovieGenre",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 1, 18, 22, 21, 27, 803, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerFavoriteMovieGenre_MovieGenre_MovieGenreId",
                table: "CustomerFavoriteMovieGenre",
                column: "MovieGenreId",
                principalTable: "MovieGenre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_MovieGenre_MovieTypeId",
                table: "Movies",
                column: "MovieTypeId",
                principalTable: "MovieGenre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerFavoriteMovieGenre_MovieGenre_MovieGenreId",
                table: "CustomerFavoriteMovieGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_MovieGenre_MovieTypeId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieGenre",
                table: "MovieGenre");

            migrationBuilder.RenameTable(
                name: "MovieGenre",
                newName: "MovieTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieTypes",
                table: "MovieTypes",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 1, 18, 22, 20, 40, 801, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 1, 18, 22, 20, 40, 801, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 1, 18, 22, 20, 40, 801, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 1, 18, 22, 20, 40, 801, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "MovieTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 1, 18, 22, 20, 40, 801, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerFavoriteMovieGenre_MovieTypes_MovieGenreId",
                table: "CustomerFavoriteMovieGenre",
                column: "MovieGenreId",
                principalTable: "MovieTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_MovieTypes_MovieTypeId",
                table: "Movies",
                column: "MovieTypeId",
                principalTable: "MovieTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
