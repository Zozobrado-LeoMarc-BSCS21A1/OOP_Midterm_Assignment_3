namespace TestProject1;

public class Book : Library
{

    private string author, title, ISBN;
    public Book(string title, string author, string ISBN)
    {

        this.title = title;
        this.author = author;
        this.ISBN = ISBN;   

    }

    public string GetTitle()
    {
        return this.title;
    }
}
