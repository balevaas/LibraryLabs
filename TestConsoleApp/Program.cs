using ClassLibrary;

List<Book> books = new List<Book>();
List<Reader> reader = new List<Reader>();

bool exit = true;
do
{
    Menu(ref exit);
} while (exit);

void Menu(ref bool exit)
{
    Console.WriteLine("Меню:\n1 - Добавить книгу\n2 - Добавить читателя\n" +
        "3 - Поиск книги\n4 - вывод списка книг\n5 - Выход\n");
    int key = int.Parse(Console.ReadLine());
    switch (key)
    {
        case 1: AddBook(); break;
        case 2: AddReader(); break;
        case 3: SearchBook(); break;
        case 4: PrintBook(); break;
        case 5: exit = false; break;
    }
}

void SearchBook()
{
    Console.WriteLine("Меню:\n1 - Поиск по артиклу\n2 - Поиск по автору\n" +
        "3 - Поиск по названию\n");
    int k = int.Parse(Console.ReadLine());
    Book book = null;
    List<Book> bookList = null;
    string poisk = Console.ReadLine();
    switch (k)
    {
        case 1:
            book = books.Find(p => p.Article == poisk);
            Console.WriteLine(book);
            break;
        case 2:
            bookList = books.FindAll(p => p.Author == poisk);
            foreach(var g in bookList)
            {
                Console.WriteLine(g);
            }
            break;
        case 3:
            book = books.Find(p => p.Name == poisk);
            Console.WriteLine(book);
            break;
    }

}

void PrintBook()
{
    foreach (Book book in books)
    {
        Console.WriteLine(book.ToString());
    }
}



void AddReader()
{
    Console.WriteLine("ФИО читателя: ");
    string fio = Console.ReadLine();
    Console.WriteLine("Номер группы: ");  
    int numberGroup = int.Parse(Console.ReadLine());
    Console.WriteLine("Количество экземпляров:");
    int countBook = int.Parse(Console.ReadLine());
    Reader reader1 = new Reader(fio, numberGroup, countBook);
    reader.Add(reader1);
}

void AddBook()
{
    Console.WriteLine("Артикул книги:");
    string article = Console.ReadLine();
    Console.WriteLine("Автор книги:");
    string author = Console.ReadLine();
    Console.WriteLine("Название книги:");
    string title = Console.ReadLine();
    Console.WriteLine("Год издания:");
    int pubYear = int.Parse(Console.ReadLine());
    Console.WriteLine("Количество экземпляров:");
    int count = int.Parse(Console.ReadLine());
    Book book = new Book(article, author, title, pubYear, count);
    books.Add(book);
}