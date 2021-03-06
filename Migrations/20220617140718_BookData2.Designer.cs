// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using zad6_1.Data;

#nullable disable

namespace zad6_1.Migrations
{
    [DbContext(typeof(BookDBContext))]
    [Migration("20220617140718_BookData2")]
    partial class BookData2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("zad6_1.Data.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<float>("Cost")
                        .HasColumnType("float");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ID");

                    b.ToTable("books");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AuthorName = "J.K. Rowling",
                            Cost = 25.34f,
                            Image = "https://images-na.ssl-images-amazon.com/images/I/81iqZ2HHD-L.jpg",
                            Name = "Harry Potter: Philosopher's Stone",
                            PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1997)
                        },
                        new
                        {
                            ID = 3,
                            AuthorName = "J.K. Rowling",
                            Cost = 25.34f,
                            Image = "https://image.ceneostatic.pl/data/products/35692256/i-harry-potter-and-the-prisoner-of-azkaban.jpg",
                            Name = "Harry Potter: Prisoner of Azkaban",
                            PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1999)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
