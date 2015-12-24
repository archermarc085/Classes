using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Book
    {
        Title title = new Title();
        Author author = new Author();
        Content content = new Content();

        public Book()
        {

        }
        public Book(string title, string author, string content)
        {
            this.title.NameofBook = title;
            this.author.NameofAuthor = author;
            this.content.TypeContent = content;
        }

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }

    class Title
    {
        string nameofbook = "";
        public string NameofBook
        {
            get { return nameofbook; }
            set { nameofbook = value; }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Title: {0}", NameofBook);
        }
    }
    class Author
    {
        string nameOfauthor = "";
        public string NameofAuthor
        {
            get { return nameOfauthor; }
            set { nameOfauthor = value; }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Name of Author: {0}", NameofAuthor);
        }

    }
    class Content
    {
        string typecontent = "";
        public string TypeContent
        {
            get { return typecontent; }
            set { typecontent = value; }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Content: {0}", TypeContent);
        }
    
    }
}
