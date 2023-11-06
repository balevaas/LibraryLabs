using System;
using static System.Reflection.Metadata.BlobBuilder;

namespace ClassLibrary
{
    public class Book
    {
        public string Article { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Count { get; set; }

        public Book(string article, string author, string name, int year, int count)
        {
            Article = article;
            Author = author;
            Name = name;
            Year = year;
            Count = count;
        }
        public Book() { }

        public void ShowGroup()
        {
            Console.WriteLine();
            Console.WriteLine($"Артикул: {Article}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Год издания: {Year}");
            Console.WriteLine($"Количество {Count}");
        }

        public void AddBook()
        {
            List<Book> books = new List<Book>()
            {
                new Book("111", "111", "111", 1, 1),
                new Book("222", "222", "222", 2, 2),
                new Book("333", "333", "333", 3, 3)
            };

            Book book = new Book();
            books.Add(book);
        }

    }
}