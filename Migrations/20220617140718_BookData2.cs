using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace zad6_1.Migrations
{
    public partial class BookData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "ID", "AuthorName", "Cost", "Image", "Name", "PublishDate" },
                values: new object[] { 1, "J.K. Rowling", 25.34f, "https://images-na.ssl-images-amazon.com/images/I/81iqZ2HHD-L.jpg", "Harry Potter: Philosopher's Stone", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1997) });

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "ID", "AuthorName", "Cost", "Image", "Name", "PublishDate" },
                values: new object[] { 3, "J.K. Rowling", 25.34f, "https://image.ceneostatic.pl/data/products/35692256/i-harry-potter-and-the-prisoner-of-azkaban.jpg", "Harry Potter: Prisoner of Azkaban", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1999) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
