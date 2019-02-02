using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Library books = ParseUserInput();

            Library.PrintBook(books, books.End);
        }

        static Library ParseUserInput()
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> listOfBooks = new List<Book>();
            Library library = new Library();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();

                string authorName = input[1];
                string bookName = input[0];
                string publisher = input[2];
                DateTime releaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string isbn = input[4];
                double price = double.Parse(input[input.Length - 1]);

                listOfBooks.Add(new Book(bookName, authorName, publisher, releaseDate, isbn, price));
            }

            library.Books = listOfBooks;
            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            library.End = endDate;
            return library;
        }
    }

    class Library
    {
        public DateTime End { get; set; }
        public List<Book> Books { get; set; }


        public static void PrintBook (Library a, DateTime end)
        {
            
            foreach(var author in a.Books.OrderBy(x=>x.ReleaseDate).ThenBy(x=>x.Title))
            {
                if (author.ReleaseDate > end)
                Console.WriteLine($"{author.Title} -> {author.ReleaseDate.ToString("dd.MM.yyyy")}");
            }
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }


        public Book(string title, string authorName, string publisher, DateTime releaseDate, string isbn, double price)
        {
            this.Title = title;
            this.AuthorName = authorName;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.ISBN = isbn;
            this.Price = price;

        }
    }
}
