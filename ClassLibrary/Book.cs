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
        public string ToString()
        {
            string result = $"Артикул: {Article}, Автор: {Author}, Название: {Name}\nГод издания: {Year}, Количество {Count}";
            return result;
        }

    }
}