using System.Collections.Generic;

public delegate void ProcessBookDelegate(Book book);

public class BookDB
{
    List<Book> list = new();
    public int TotalAmountOfBooks { get { return list.Count; } }

    public void AddBook(string title, string author, decimal price, bool paperBack)
    {
        list.Add(new Book(title, author, price, paperBack));
    }

    public void ProcessPaperbackBooks(ProcessBookDelegate processBook)
    {
        foreach (Book b in list)
        {
            if (b.Paperback)
            {
                processBook(b);
            }
        }
    }

    public void ProcessAllBooks(ProcessBookDelegate processBook)
    {
        foreach (Book b in list)
        {
            processBook(b);
        }
    }
}