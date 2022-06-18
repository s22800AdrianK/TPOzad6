using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace zad6_1.Migrations
{
    public partial class BookData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "ID", "AuthorName", "Cost", "Image", "Name", "PublishDate" },
                values: new object[] { 2, "J.K. Rowling", 27.34f, "https://m.media-amazon.com/images/I/51mFoFmu0EL._AC_SY1000_.jpg", "Harry Potter: Chamber of Secrets", new DateTime(1998, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
