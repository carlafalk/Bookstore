using System.Collections.Generic;
using System;

public class BooksInPriceRange
{
    private decimal minPrice = 15;
    private decimal maxPrice = 100;
    public decimal MinPrice { get { return minPrice; } }
    public decimal MaxPrice { get { return maxPrice; } }

    private List<Book> booksInAcceptedRange = new();
    public void GetSomewhatCheapBooks(Book book)
    {

        if (book.Price >= MinPrice && book.Price <= MaxPrice)
        {
            booksInAcceptedRange.Add(book);
        }
    }

    public IList<Book> ReturnListOfBooks()
    {
        return booksInAcceptedRange.AsReadOnly();
    }
}