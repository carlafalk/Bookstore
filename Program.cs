using System;

class Program
{
    static void Main()
    {
        BookDB bookDB = new BookDB();

        AddExampleBooks(bookDB);

        Console.WriteLine($"Total amount of books: {bookDB.Books.Count}");

        Console.WriteLine("Paperback Book Titles:");
        bookDB.ProcessPaperbackBooks(PrintBookTitle);

        PriceTotaller totaller = new PriceTotaller();

        bookDB.ProcessPaperbackBooks(totaller.AddBookToTotal);

        Console.WriteLine("Average Paperback Book Price: ${0:#.##}", totaller.AveragePrice());
    }

    static void PrintBookTitle(Book b)
    {
        Console.WriteLine($"   {b.Title}");
    }

    static void AddExampleBooks(BookDB bookDB)
    {
        bookDB.AddBook("The C Programming Language", "Brian W. Kernighan and Dennis M. Ritchie", 19.95m, true);
        bookDB.AddBook("The Unicode Standard 2.0", "The Unicode Consortium", 39.95m, true);
        bookDB.AddBook("The MS-DOS Encyclopedia", "Ray Duncan", 129.95m, false);
        bookDB.AddBook("Dogbert's Clues for the Clueless", "Scott Adams", 12.00m, true);
    }
}