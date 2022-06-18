using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using zad6_1.Data;

namespace zad6_1.Configuration;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{

    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(e => e.ID);
        builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
        builder.Property(e => e.AuthorName).HasMaxLength(200).IsRequired();
        builder.Property(e => e.Cost).IsRequired();
        builder.Property(e => e.Image).IsRequired();
        builder.Property(e => e.PublishDate).IsRequired();

        var booksData = new List<Book>
        {
            new Book{ ID=1,Name="Harry Potter: Philosopher's Stone", AuthorName="J.K. Rowling", Cost=25.34f, PublishDate=new DateTime(1997,7,26), Image="https://images-na.ssl-images-amazon.com/images/I/81iqZ2HHD-L.jpg"},
            new Book{ ID=2,Name="Harry Potter: Chamber of Secrets", AuthorName="J.K. Rowling", Cost=27.34f, PublishDate=new DateTime(1998,7,2), Image="https://m.media-amazon.com/images/I/51mFoFmu0EL._AC_SY1000_.jpg"},
            new Book{ ID=3,Name="Harry Potter: Prisoner of Azkaban", AuthorName="J.K. Rowling", Cost=25.34f, PublishDate=new DateTime(1999,7,8), Image="https://image.ceneostatic.pl/data/products/35692256/i-harry-potter-and-the-prisoner-of-azkaban.jpg"},
            new Book{ ID=4,Name="Harry Potter: Goblet of Fire", AuthorName="J.K. Rowling", Cost=23.34f, PublishDate=new DateTime(2000,7,8), Image="https://m.media-amazon.com/images/I/51rwzf9iytL._AC_SY780_.jpg"},
            new Book{ ID=5,Name="Harry Potter: Order of the Phoenix", AuthorName="J.K. Rowling", Cost=21.99f, PublishDate=new DateTime(2003,6,27), Image="https://m.media-amazon.com/images/I/51lFAzVQUxL._AC_SY580_.jpg"},
            new Book{ ID=6,Name="Harry Potter: Half-Blood Prince", AuthorName="J.K. Rowling", Cost=21.99f, PublishDate=new DateTime(2005,7,16), Image="https://m.media-amazon.com/images/I/51nRdIU2qHL._AC_SY580_.jpg"},
            new Book{ ID=7,Name="Harry Potter: Deathly Hallows", AuthorName="J.K. Rowling", Cost=29.99f, PublishDate=new DateTime(2007,7,14), Image="https://m.media-amazon.com/images/I/51RdS8EJEJL._AC_SY580_.jpg"},
            new Book{ ID=8,Name="Nineteen Eighty-Four", AuthorName="George Orwell", Cost=15.69f, PublishDate=new DateTime(1949,6,8), Image="https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/1984first.jpg/220px-1984first.jpg"},
            new Book{ ID=9,Name="Dune", AuthorName="Frank Herbert", Cost=23.69f, PublishDate=new DateTime(1965,8,1), Image="https://upload.wikimedia.org/wikipedia/en/thumb/d/de/Dune-Frank_Herbert_%281965%29_First_edition.jpg/220px-Dune-Frank_Herbert_%281965%29_First_edition.jpg"},
            new Book{ ID=10,Name="Dune Messiah", AuthorName="Frank Herbert", Cost=23.69f, PublishDate=new DateTime(1969,8,1), Image="https://upload.wikimedia.org/wikipedia/en/4/46/Dune_Messiah-Frank_Herbert_%281969%29_First_edition.jpg"},
            new Book{ ID=11,Name="God Emperor of Dune", AuthorName="Frank Herbert", Cost=23.69f, PublishDate=new DateTime(1981,1,1), Image="https://upload.wikimedia.org/wikipedia/en/a/a7/God_Emperor_of_Dune-Frank_Herbert_%281981%29_First_edition.jpg"},
            new Book{ ID=12,Name="Heretics of Dune", AuthorName="Frank Herbert", Cost=23.69f, PublishDate=new DateTime(1984,1,1), Image="https://upload.wikimedia.org/wikipedia/en/d/de/Heretics_of_Dune-Frank_Herbert_%281984%29_First_edition.jpg"},
            new Book{ ID=13,Name="Chapterhouse: Dune", AuthorName="Frank Herbert", Cost=23.69f, PublishDate=new DateTime(1985,4,1), Image="https://upload.wikimedia.org/wikipedia/en/8/82/Chapterhouse_Dune-Frank_Herbert_%281985%29_First_edition.jpg"},
            new Book{ ID=14,Name="Dune: House Atreides", AuthorName="Frank Herbert", Cost=23.69f, PublishDate=new DateTime(1985,1,1), Image="https://upload.wikimedia.org/wikipedia/en/6/67/Dune_House_Atreides_%281999%29.jpg"}, 
            new Book{ ID=15,Name="Dune: House Harkonnen", AuthorName="Frank Herbert", Cost=23.69f, PublishDate=new DateTime(2000,1,1), Image="https://upload.wikimedia.org/wikipedia/en/1/16/Dune_House_Harkonnen_%282000%29.jpg"},         
        };
        builder.HasData(booksData);
    }
} 