using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace zad6_1.Migrations
{
    public partial class BookData6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "ID",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(1997, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "ID",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(1998, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "ID", "AuthorName", "Cost", "Image", "Name", "PublishDate" },
                values: new object[,]
                {
                    { 8, "George Orwell", 15.69f, "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/1984first.jpg/220px-1984first.jpg", "Nineteen Eighty-Four", new DateTime(1949, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Frank Herbert", 23.69f, "https://upload.wikimedia.org/wikipedia/en/thumb/d/de/Dune-Frank_Herbert_%281965%29_First_edition.jpg/220px-Dune-Frank_Herbert_%281965%29_First_edition.jpg", "Dune", new DateTime(1965, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Frank Herbert", 23.69f, "https://upload.wikimedia.org/wikipedia/en/4/46/Dune_Messiah-Frank_Herbert_%281969%29_First_edition.jpg", "Dune Messiah", new DateTime(1969, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "Frank Herbert", 23.69f, "https://upload.wikimedia.org/wikipedia/en/a/a7/God_Emperor_of_Dune-Frank_Herbert_%281981%29_First_edition.jpg", "God Emperor of Dune", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "Frank Herbert", 23.69f, "https://upload.wikimedia.org/wikipedia/en/d/de/Heretics_of_Dune-Frank_Herbert_%281984%29_First_edition.jpg", "Heretics of Dune", new DateTime(1984, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "Frank Herbert", 23.69f, "https://upload.wikimedia.org/wikipedia/en/8/82/Chapterhouse_Dune-Frank_Herbert_%281985%29_First_edition.jpg", "Chapterhouse: Dune", new DateTime(1985, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "Frank Herbert", 23.69f, "https://upload.wikimedia.org/wikipedia/en/6/67/Dune_House_Atreides_%281999%29.jpg", "Dune: House Atreides", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "Frank Herbert", 23.69f, "https://upload.wikimedia.org/wikipedia/en/1/16/Dune_House_Harkonnen_%282000%29.jpg", "Dune: House Harkonnen", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "ID",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(1997, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "ID",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(1998, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
