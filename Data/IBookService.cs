namespace zad6_1.Data;

public interface IBookService 
{
    public List<Book> GetBooks();
    public List<Book> SearchBooks(string value);
}