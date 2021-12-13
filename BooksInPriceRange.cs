using System.Collections.Generic;
using System;

public class BooksInPriceRange
{
    private decimal minPrice;
    private decimal maxPrice;
    public decimal MinPrice { get { return minPrice; } }
    public decimal MaxPrice { get { return maxPrice; } }

    public BooksInPriceRange(int _minPrice, int _maxPrice)
    {
        this.minPrice = _minPrice;
        this.maxPrice = _maxPrice;
    }

    private List<Book> booksInAcceptedRange = new();
    public void GetSomewhatCheapBooks(Book book)
    {
        if (book.Price >= MinPrice && book.Price <= MaxPrice) booksInAcceptedRange.Add(book);
    }

    public IList<Book> ReturnListOfBooks()
    {
        return booksInAcceptedRange.AsReadOnly();
    }
}