using System.Collections.Generic;
using System;

public class BookDB
{

    List<Book> list = new();
    public int TotalAmountOfBooks { get { return list.Count; } }

    public void AddBook(string title, string author, decimal price, bool paperBack)
    {
        list.Add(new Book(title, author, price, paperBack));
    }

    public void ProcessPaperbackBooks(Action<Book> bookAction)
    {
        foreach (Book b in list)
        {
            if (b.Paperback)
            {
                bookAction(b);
            }
        }
    }

    public void ProcessAllBooks(Action<Book> bookAction)
    {
        foreach (Book b in list)
        {
            bookAction(b);
        }
    }
}