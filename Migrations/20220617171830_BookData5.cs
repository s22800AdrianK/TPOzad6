using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace zad6_1.Migrations
{
    public partial class BookData5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "ID",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(1997, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "ID", "AuthorName", "Cost", "Image", "Name", "PublishDate" },
                values: new object[] { 6, "J.K. Rowling", 21.99f, "https://m.media-amazon.com/images/I/51nRdIU2qHL._AC_SY580_.jpg", "Harry Potter: Half-Blood Prince", new DateTime(2005, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "ID", "AuthorName", "Cost", "Image", "Name", "PublishDate" },
                values: new object[] { 7, "J.K. Rowling", 29.99f, "https://m.media-amazon.com/images/I/51RdS8EJEJL._AC_SY580_.jpg", "Harry Potter: Deathly Hallows", new DateTime(2007, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "ID",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1997));
        }
    }
}
