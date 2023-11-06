using ClassLibrary;

namespace TestConsoleApp
{
    internal class Test
    {
        static void Main(string[] args)
        {

            List<Book> books = new List<Book>();
            List<Reader> reader = new List<Reader>();
            Book b = new Book();
            b.AddBook();
            b.ShowGroup();
        }
    }
}