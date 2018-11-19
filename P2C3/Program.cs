using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2C3
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        void GetBook()
        {
            var myFavouriteBook = new Book(title: "Shoe dog", author: "Phil Knight", numberOfPages: 345);
            var anotherFavouriteBook = new Book(title: "Steve Jobs", author: "Walter Isaacson", numberOfPages: 567);
            myFavouriteBook.read();
        }
    }

    class Book
    {
        string title;
        string author;
        int numberOfPages;
        static int numberOfPagesRead = 0;

        public Book(string title, string author, int numberOfPages)
        {
            this.title = "Coding is art";
            this.author = "Becky James";
            this.numberOfPages = 425;
        }

        public void read()
        {
            //numberOfPagesRead = numberOfPagesRead + 1;
            Book.numberOfPagesRead = Book.numberOfPagesRead + 1;
        }
    }

    class Calendar
    {
        const int numberOfWeekdays = 7;
    }

}
