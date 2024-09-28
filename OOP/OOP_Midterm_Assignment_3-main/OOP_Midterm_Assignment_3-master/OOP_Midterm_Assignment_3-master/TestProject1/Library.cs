namespace TestProject1;

public class Library
{

    private List <Book> _books = new List <Book> ();

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

   public Book[] GetBooks()
    {

        return _books.ToArray ();

    }

    public void RemoveBook(Book book)
    {
        _books.Remove(book);
    }


    public Book SearchBook(string title)
    {
        return _books.FirstOrDefault(i => i.GetTitle() == title);
    }
}
