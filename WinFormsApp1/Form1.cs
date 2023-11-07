using ClassLibrary;
using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string artricle, author, name;
        int year, count;
        BindingList<Book> books = new BindingList<Book>();
        public Form1()
        {
            InitializeComponent();
            InitializeBooks();
        }

        private void InitializeBooks()
        {
            books.Add(new Book("1468", "Л.Н. Толстой", "Война и мир", 1867, 1));
            books.Add(new Book("1469", "Л.Н. Толстой", "Анна Каренина", 1877, 1));
            books.Add(new Book("1470", "Л.Н. Толстой", "Анна Каренина", 2023, 10));
            dataGridView1.DataSource = books;
        }

        private void AddBook()
        {
            books.Add(new Book() { Article = artricle, Author = author, Name = name, Year = year, Count = count });
            dataGridView1.DataSource = books;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            artricle = articleTB.Text;
            author = authorTB.Text;
            name = nameTB.Text;
            year = int.Parse(yearTB.Text);
            count = int.Parse(countTB.Text);
            AddBook();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string search = searchCB.SelectedItem.ToString();
            Book bookSearch = new Book();
            BindingList<Book> searchList = new BindingList<Book>();
            switch (search)
            {
                case "Артикул":
                    dataGridView2.DataSource = new object();
                    bookSearch = books.SingleOrDefault(p => p.Article == searchTB.Text);
                    searchList.Add(bookSearch);
                    dataGridView2.DataSource = searchList;
                    break;
                //case "Автор":
                //    bookSearch = books.SingleOrDefault(p => p.Author == searchTB.Text);
                //    searchList.Add(bookSearch);
                //    dataGridView2.DataSource = searchList;
                //    break;
                case "Название":
                    dataGridView2.DataSource = new object();
                    bookSearch = (Book)books.Select(p => p.Name == searchTB.Text);
                    searchList.Add(bookSearch);
                    dataGridView2.DataSource = searchList;
                    break;
                default:
                    MessageBox.Show("Ошибка");
                    break;
            }
        }
        /*switch (k)
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
    }*/
    }
}