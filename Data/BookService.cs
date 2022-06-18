using System;
namespace zad6_1.Data;

public class BookService : IBookService
{
    private readonly BookDBContext _context;

    public BookService(BookDBContext context)
    {
        _context = context;
    }

    public List<Book> GetBooks()
    {
       return _context.books.ToList();
    }
    public List<Book> SearchBooks(string value)
    {
        return _context.books.Where(e => 
        e.Name.ToLower().Contains(value.ToLower())||
        e.AuthorName.ToLower().Contains(value.ToLower())
        ).ToList();
    }
}