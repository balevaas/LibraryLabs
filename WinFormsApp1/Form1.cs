using ClassLibrary;
using TestConsoleApp;
using System;
using static System.Reflection.Metadata.BlobBuilder;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string artricle, author, name;
        int year, count;
        List<Book> books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void add()
        {
            books.Add(new Book() { Article = artricle, Author = author, Name = name, Year = year, Count = count });
            dataGridView1.DataSource = books;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            artricle = textBox1.Text;
            author = textBox2.Text;
            name = textBox3.Text;
            year = int.Parse(textBox4.Text);
            count = int.Parse(textBox5.Text);

            add();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            books.Add(new Book("444", "444", "444", 4, 4));
            dataGridView1.DataSource = books;

            // added a new item
            books.Add(new Book() { Article = "555", Author = "555", Name = "555", Year = 5, Count = 5 });

            // bind to the updated source
            dataGridView1.DataSource = books;
        }
    }
}