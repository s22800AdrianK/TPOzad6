using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace zad6_1.Migrations
{
    public partial class BookData4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "ID",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(1999, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "ID", "AuthorName", "Cost", "Image", "Name", "PublishDate" },
                values: new object[] { 4, "J.K. Rowling", 23.34f, "https://m.media-amazon.com/images/I/51rwzf9iytL._AC_SY780_.jpg", "Harry Potter: Goblet of Fire", new DateTime(2000, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "ID", "AuthorName", "Cost", "Image", "Name", "PublishDate" },
                values: new object[] { 5, "J.K. Rowling", 21.99f, "https://m.media-amazon.com/images/I/51lFAzVQUxL._AC_SY580_.jpg", "Harry Potter: Order of the Phoenix", new DateTime(2003, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "ID",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1999));
        }
    }
}
