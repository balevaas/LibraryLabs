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

        /// <summary>
        /// переопределение метода ToString()
        /// </summary>
        /// <returns>строка: артикул, автор, название, год издания количество, экземпляров</returns>
        public override string ToString()
        {
            return $"Артикул: {Article}\nАвтор: {Author}\n" +
                $"Название: {Name}\nГод издания: {Year}\n" +
                $"Количество копий: {Count}\n";
        }

    }
}